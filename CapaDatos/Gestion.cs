﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class Gestion
    {
        private RutaBikesDbEntitiesN bikeEntities = new RutaBikesDbEntitiesN();

        public Usuario Login(string email, string contrasena)
        {
            return bikeEntities.Usuarios.FirstOrDefault(u => u.email.ToLower().Equals(email.ToLower()) && u.contrasena.Equals(contrasena));
        }

        public Usuario Register(string email, string contrasena, int telefono, string numCuenta, float monedero, out string error)
        {
            error = "";
            if (bikeEntities.Usuarios.Any(usr => usr.email.Equals(email)))
            {
                error = "ERROR. Ya existe un usuario con ese email.";
                return null;
            }
            Usuario newUser = new Usuario(email, contrasena, telefono, numCuenta, monedero);
            try
            {
                bikeEntities.Usuarios.Add(newUser);
                var nFilas = bikeEntities.SaveChanges();
                if (nFilas == 0) {
                    error = "ERROR al crear el nuevo usuario.";
                    return null;
                }
            }catch(Exception e)
            {
                error = e.Message;
                return null;
            }
            error = $"Usuario con email {email} registrado correctamente.";
            return newUser;
        }

        public List<Estacion> ObtenerEstaciones()
        {
            return bikeEntities.Estacions.ToList();
        }

        public List<Anclaje> ObtenerAnclajesDeEstacion(int idEstacion)
        {
            return bikeEntities.Anclajes.Where(a => a.idEstacion == idEstacion).ToList();
        }

        public Boolean UserHasActiveTrip(int idUser)
        {
            return bikeEntities.Usuarios.Find(idUser).Viajes.Any(viaje => viaje.idAnclajeFin == null);
        }

        public string IniciarViaje(int idUser, int idAnclajeIni, DateTime fechaIni)
        {
            var user = bikeEntities.Usuarios.Find(idUser);
            if (user == null) return "Usuario no existe";

            var userTrips = user.Viajes.Any(viaje => viaje.idAnclajeFin == null);
            if (userTrips) return $"El usuario con email {user.email} ya tiene un viaje iniciado sin terminar.";

            if (user.monedero < 0.70) return $"El usuario no tiene suficiente dinero en la cuenta para iniciar el viaje. Saldo: {user.monedero}, necesarios: {0.70 - user.monedero} €";

            var anclaje = bikeEntities.Anclajes.Find(idAnclajeIni);
            if (anclaje == null || anclaje.Bicicleta == null) return "Anclaje no existe o no tiene bicicleta";

            try
            {
                Viaje newViaje = new Viaje(idUser, anclaje.idBici, fechaIni, anclaje, user);

                //Quitar bicicleta de ese anclaje para ponerla en otro al finalizar el viaje
                anclaje.Bicicleta = null;
                anclaje.idBici = null;

                bikeEntities.Viajes.Add(newViaje);
                var filas = bikeEntities.SaveChanges();
                if (filas == 0) return "Error al iniciar el viaje";
            }catch(Exception e)
            {
                return e.Message;
            }
            return "Viaje creado con éxito.";
        }

        public string FinalizarViaje(int idUser, int idAnclajeFin, DateTime fechaFin)
        {
            var user = bikeEntities.Usuarios.Find(idUser);
            if (user == null) return "Usuario no existe";

            var userTrip = user.Viajes.FirstOrDefault(viaje => viaje.idAnclajeFin == null);
            if (userTrip == null) return $"El usuario con email {user.email} no tiene viajes en curso.";

            var anclaje = bikeEntities.Anclajes.Find(idAnclajeFin);
            if (anclaje == null || anclaje.Bicicleta != null) return "Anclaje no existe o no está libre";

            TimeSpan result = fechaFin.Subtract(userTrip.fechaInicio);
            Tarifa tarifa = bikeEntities.Tarifas.FirstOrDefault(tarif => result.TotalMinutes <= tarif.maxTiempo && result.TotalMinutes > tarif.minTiempo);
            if (tarifa == null) return "No se ha podido aplicar una tarifa.";

            double precioFinal = tarifa.precioBase * result.TotalMinutes + userTrip.precio;

            if (user.monedero < precioFinal) return $"El usuario no tiene suficiente dinero en la cuenta para pagar el viaje. Saldo: {user.monedero}, necesarios: {precioFinal - user.monedero} €";
           
            Bicicleta bici = bikeEntities.Bicicletas.Find(userTrip.idBici);
            if (bici == null) return "Bicicleta no registrada";

            try
            {
                userTrip.fechaFin = fechaFin;
                userTrip.precio = precioFinal;
                userTrip.idAnclajeFin = idAnclajeFin;

                //Añadir la bicicleta al anclaje nuevo
                anclaje.Bicicleta = bici;
                anclaje.idBici = userTrip.idBici;
                userTrip.Anclaje1 = anclaje;

                var filas = bikeEntities.SaveChanges();
                if (filas == 0) return "Error al finalizar el viaje";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "Viaje finalizado con éxito.";
        }

        public Usuario ModificarUsuario(int idUser, string email, int telefono, string numCuenta, out string error)
        {
            Usuario userFinal = ModificarUsuario(idUser,email, telefono, numCuenta, "", out string error2);
            error = error2;
            return userFinal;
        }
        public Usuario ModificarUsuario(int idUser, string email, int telefono, string numCuenta, string contrasena, out string error2)
        {
            error2 = "";
            Usuario userActual = bikeEntities.Usuarios.Find(idUser);
            var userEmail = bikeEntities.Usuarios.Any(usr => usr.email.ToLower().Equals(email.ToLower()) && !usr.id.Equals(idUser));
            if (userEmail)
            {
                error2 = "Ya existe un usuario con ese email. Introduce uno diferente";
                return null;
            }
            try
            {
                userActual.email = email;
                userActual.telefono = telefono;
                userActual.numCuenta = numCuenta;
                if(!contrasena.Equals("")) userActual.contrasena = contrasena;
                var filas = bikeEntities.SaveChanges();
                if (filas == 0)
                {
                    error2 = "Error al modificar el usuario";
                    return null;
                }
            }
            catch (Exception e)
            {
                error2 = e.Message;
                return null;
            }
            return userActual;
        }
    }
}

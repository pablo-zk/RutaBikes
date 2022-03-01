using System;
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

        public string IniciarViaje(int idUser, int idAnclajeIni, DateTime fechaIni, string idBici)
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
                Viaje newViaje = new Viaje(idUser, idBici, fechaIni, anclaje, user);

                //Quitar bicicleta de ese anclaje para ponerla en otro al finalizar el viaje
                //newViaje.idBici = anclaje.idBici;
                anclaje.Bicicleta = null;
                anclaje.idBici = null;
                //var nFilas = bikeEntities.SaveChanges();
                //if (nFilas == 0) return "Error al iniciar el viaje";

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

            try
            {
                userTrip.fechaFin = fechaFin;
                userTrip.idAnclajeFin = idAnclajeFin;
                userTrip.Anclaje1 = anclaje;
                userTrip.precio = precioFinal;

                //Añadir la bicicleta al anclaje nuevo
                //anclaje.Bicicleta = bikeEntities.Bicicletas.Find(userTrip.idBici);
                //anclaje.idBici = userTrip.idBici;

                
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "Viaje creado con éxito.";
        }

        public Usuario ModificarUsuario(int idUser, string email, int telefono, string numCuenta, out string error)
        {
            error = "";
            Usuario userActual = bikeEntities.Usuarios.Find(idUser);
            return ModificarUsuario(userActual.id,email, telefono, numCuenta,out error);
        }
        public Usuario ModificarUsuario(int idUser, string email, int telefono, string numCuenta, string contrasena, string repContrasena, out string error)
        {
            error = "";
            Usuario userActual = bikeEntities.Usuarios.Find(idUser);
            var userEmail = bikeEntities.Usuarios.Any(usr => usr.email.Equals(email) && !usr.id.Equals(idUser));
            if (userEmail)
            {
                error = "Ya existe un usuario con ese email. Introduce uno diferente";
                return null;
            }
            try
            {
                userActual.email = email;
                userActual.telefono = telefono;
                userActual.numCuenta = numCuenta;
                var filas = bikeEntities.SaveChanges();
                if (filas == 0)
                {
                    error = "Error al modificar el usuario";
                    return null;
                }
            }
            catch (Exception e)
            {
                error = e.Message;
                return null;
            }
            return userActual;
        }
    }
}

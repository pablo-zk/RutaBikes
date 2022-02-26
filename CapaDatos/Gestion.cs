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
        private RutaBikesDbEntities bikeEntities = new RutaBikesDbEntities();

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
                Viaje newViaje = new Viaje(idUser, fechaIni, anclaje, user);

                //Quitar bicicleta de ese anclaje para ponerla en otro al finalizar el viaje
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
    }
}

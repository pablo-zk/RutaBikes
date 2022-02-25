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

        public Boolean Login(string email, string contrasena)
        {
            return bikeEntities.Usuarios.FirstOrDefault(u => u.email.ToLower().Equals(email.ToLower()) && u.contrasena.Equals(contrasena)) == null ? false : true;
        }

        public string Register(string email, string contrasena, int telefono, string numCuenta, float monedero)
        {
            var usuario = bikeEntities.Usuarios.Where(usr => usr.email.Equals(email)).ToList();
            if (usuario.Count() != 0) return "ERROR. Ya existe un usuario con ese email.";
            try
            {
                Usuario newUser = new Usuario(email, contrasena, telefono, numCuenta, monedero);
                bikeEntities.Usuarios.Add(newUser);
                var nFilas = bikeEntities.SaveChanges();
                if (nFilas == 0) return "ERROR al crear el nuevo usuario.";
            }catch(Exception e)
            {
                return e.Message;
            }
            return $"Usuario con email {email} registrado correctamente.";
        }

        public List<Estacion> ObtenerEstaciones()
        {
            return bikeEntities.Estacions.ToList();
        }

        public List<Anclaje> ObtenerAnclajesDeEstacion(int idEstacion)
        {
            return bikeEntities.Anclajes.Where(a => a.idEstacion == idEstacion).ToList();
        }
    }
}

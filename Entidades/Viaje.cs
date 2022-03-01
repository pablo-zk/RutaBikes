//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Viaje
    {
        public int id { get; set; }
        public Nullable<int> idUser { get; set; }
        public string idBici { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFin { get; set; }
        public Nullable<int> idAnclajeIni { get; set; }
        public Nullable<int> idAnclajeFin { get; set; }
        public double precio { get; set; }
    
        public virtual Anclaje Anclaje { get; set; }
        public virtual Anclaje Anclaje1 { get; set; }
        public virtual Bicicleta Bicicleta { get; set; }
        public virtual Usuario Usuario { get; set; }
        public Viaje() { }

        public Viaje(int? idUser,string idBici, DateTime fechaInicio, Anclaje anclaje, Usuario usuario)
        {
            this.idUser = idUser;
            this.idBici = idBici;
            this.fechaInicio = fechaInicio;
            this.precio = 0.70;
            Anclaje = anclaje;
            this.idAnclajeIni = anclaje.id;
            Usuario = usuario;
        }


        public Viaje(int id, int? idUser,string idBici ,DateTime fechaInicio, DateTime fechaFin, int? idAnclajeIni, int? idAnclajeFin, double precio)
        {
            this.id = id;
            this.idUser = idUser;
            this.idBici = idBici;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.idAnclajeIni = idAnclajeIni;
            this.idAnclajeFin = idAnclajeFin;
            this.precio = precio;
        }

        public Viaje(int id, DateTime fechaInicio, DateTime fechaFin, double precio)
        {
            this.id = id;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.precio = precio;
        }
    }
}

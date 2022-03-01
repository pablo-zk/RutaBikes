using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ViajeDTO:Viaje
    {
        public string estacionOrigen { get; set; }
        public string estacionDestino { get; set; }

        public ViajeDTO() { }

        public ViajeDTO(int id, int? idUser, string idBici, DateTime fechaInicio, DateTime fechaFin, int? idAnclajeIni, int? idAnclajeFin, double precio, string estacionOrigen, string estacionDestino):base( id, idUser, idBici ,fechaInicio,  fechaFin,  idAnclajeIni, idAnclajeFin, precio)
        {
            this.estacionOrigen = estacionOrigen;
            this.estacionDestino = estacionDestino;
        }

    }
}

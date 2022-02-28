using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class GestionDS
    {
        DSBikes dsBikes;
        DSBikesTableAdapters.UsuarioTableAdapter daUsuario;
        DSBikesTableAdapters.EstacionTableAdapter daEstacion;
        DSBikesTableAdapters.AnclajeTableAdapter daAnclaje;
        DSBikesTableAdapters.BicicletaTableAdapter daBici;
        DSBikesTableAdapters.ViajeTableAdapter daViaje;
        DSBikesTableAdapters.TarifaTableAdapter daTarifa;
        
        public GestionDS(out string error)
        {
            error = "";
            dsBikes = new DSBikes();
            try
            {
                daUsuario = new DSBikesTableAdapters.UsuarioTableAdapter();
                daEstacion = new DSBikesTableAdapters.EstacionTableAdapter();
                daAnclaje = new DSBikesTableAdapters.AnclajeTableAdapter();
                daBici = new DSBikesTableAdapters.BicicletaTableAdapter();
                daViaje = new DSBikesTableAdapters.ViajeTableAdapter();
                daTarifa = new DSBikesTableAdapters.TarifaTableAdapter();
                daUsuario = new DSBikesTableAdapters.UsuarioTableAdapter();
                daUsuario.Fill(dsBikes.Usuario);
                daEstacion.Fill(dsBikes.Estacion);
                daAnclaje.Fill(dsBikes.Anclaje);
                daBici.Fill(dsBikes.Bicicleta);
                daViaje.Fill(dsBikes.Viaje);
                daTarifa.Fill(dsBikes.Tarifa);
            }catch(Exception e)
            {
                error = e.Message;
            }
        }

        public List<EstacionDTO> ObtenerEstaciones()
        {
            return dsBikes.Estacion.Select(l => new EstacionDTO(l.id, l.ubicacion, l.GetAnclajeRows().Select(a => new Anclaje(a.idEstacion, a.id, a.idBici)).ToList())).ToList();
        }

        public List<Anclaje> ObtenerAnclajesDeEstacion(int idEstacion)
        {
            return dsBikes.Anclaje.Select(a => new Anclaje(a.idEstacion, a.id, a.idBici)).ToList();
        }
    }
}

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

        //public List<EstacionDTO> ObtenerEstaciones()
        //{
        //    return dsBikes.Estacion.Select(l => new EstacionDTO(l.id, l.ubicacion, l.GetAnclajeRows().Select(a => new Anclaje(a.idEstacion, a.id, a.IsidBiciNull()?null:a.idBici)).ToList())).ToList();
        //}

        //public List<Anclaje> ObtenerAnclajesDeEstacion(int idEstacion)
        //{
        //    return dsBikes.Anclaje.Where(a => a.idEstacion.Equals(idEstacion)).Select(a => new Anclaje(a.idEstacion, a.id, a.IsidBiciNull() ? null : a.idBici)).ToList();
        //}

        public List<ViajeDTO> HistorialViajesUser(int idUser)
        {
            daViaje.Fill(dsBikes.Viaje);
            daEstacion.Fill(dsBikes.Estacion);
            daAnclaje.Fill(dsBikes.Anclaje);
            return dsBikes.Viaje.Where(vi => vi.idUser.Equals(idUser)).Select(vi => new ViajeDTO(
                vi.id, 
                vi.idUser,
                vi.idBici, 
                vi.fechaInicio, 
                vi.fechaFin, 
                vi.IsidAnclajeIniNull() ? -1 : vi.idAnclajeIni,
                vi.IsidAnclajeFinNull() ? -1 : vi.idAnclajeFin,
                vi.precio,
                vi.IsidAnclajeIniNull() ? null : dsBikes.Anclaje.FindByid(vi.idAnclajeIni).EstacionRow.ubicacion,
                vi.IsidAnclajeFinNull() ? null : dsBikes.Anclaje.FindByid(vi.idAnclajeFin).EstacionRow.ubicacion
                )).OrderByDescending(vi => vi.fechaInicio).ToList();
        }

        public ViajeDTO ObtenerViajePorId(int idViaje)
        {
            //Viaje viaje = bikeEntities.Viajes.FirstOrDefault(vi => vi.id == idViaje);
            //String estacionOrigen = bikeEntities.Anclajes.Find(viaje.idAnclajeIni).Estacion.ubicacion;
            //String estacionFin = viaje.idAnclajeIni != null ? bikeEntities.Anclajes.Find(viaje.idAnclajeFin).Estacion.ubicacion : null;
            //return new ViajeDTO(viaje.id, viaje.fechaInicio, viaje.fechaFin, viaje.precio, estacionOrigen, estacionFin);
            daViaje.Fill(dsBikes.Viaje);
            daEstacion.Fill(dsBikes.Estacion);
            daAnclaje.Fill(dsBikes.Anclaje);
            return dsBikes.Viaje.Where(vi => vi.id == idViaje).Select(vi => new ViajeDTO(
                vi.id, 
                vi.fechaInicio, 
                vi.fechaFin, 
                vi.precio,
                vi.IsidAnclajeIniNull() ? null : dsBikes.Anclaje.FindByid(vi.idAnclajeIni).EstacionRow.ubicacion,
                vi.IsidAnclajeFinNull() ? null : dsBikes.Anclaje.FindByid(vi.idAnclajeFin).EstacionRow.ubicacion
                )).FirstOrDefault();
        }
    }
}

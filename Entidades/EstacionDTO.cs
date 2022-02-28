using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstacionDTO
    {
        public int id { get; set; }
        public string ubicacion { get; set; }
        public List<Anclaje> anclajes { get; set; }

        public EstacionDTO()
        {
        }

        public EstacionDTO(int id, string ubicacion, List<Anclaje> anclajes)
        {
            this.id = id;
            this.ubicacion = ubicacion;
            this.anclajes = anclajes;
        }
    }
}

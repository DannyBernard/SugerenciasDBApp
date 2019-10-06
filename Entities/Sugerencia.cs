using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class Sugerencia
    { [Key]
        public int SugerenciaID { get; set; }
        public DateTime Fecha{ get; set; }
        public string Descripcion  { get; set; }

        public Sugerencia(int sugerenciaID, DateTime fecha, string descripcion)
        {
            SugerenciaID = sugerenciaID;
            Fecha = fecha;
            Descripcion = descripcion;
        }

        public Sugerencia()
        {
            SugerenciaID = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            
        }

    }
}

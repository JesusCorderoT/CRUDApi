using System;

namespace CRUDApi.Models
{
    public class AlumnosM
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string correo { get; set; }
        public int telefono{ get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string curp { get; set; }
        public decimal sueldo { get; set; }
        public int idestadoorigen{ get; set; }
        public int idEstatus { get; set; }

    }
}

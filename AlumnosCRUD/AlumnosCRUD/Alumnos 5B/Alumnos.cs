using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AlumnosCRUD.Alumnos_5B
{
    class Alumnos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
        public string Edad { get; set; }
        public string Sexo { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - {Area} - {Edad}-{Sexo}";
        }
    }
}

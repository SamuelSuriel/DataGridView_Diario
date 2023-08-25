using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_Diario.Models
{
    public class EntradaDiario
    {
        public int Cuenta { get; set; }
        public string? NombreCuenta { get; set; }
        public string? Tipo { get; set; }
        public int Monto { get; set; }
    }
}

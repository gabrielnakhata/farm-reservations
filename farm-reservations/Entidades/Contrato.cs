using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizing_life.Entidades
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public int IdReserva { get; set; }
        public int IdChacara { get; set; }
        public int IdCliente { get; set; }
        public DateTime Contratacao { get; set; }
        public DateTime Devolucao { get; set; }
        public decimal ValorFinal { get; set; }
    }
}

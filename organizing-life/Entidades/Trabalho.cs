using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizing_life.Entidades
{
    public class Trabalho
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public decimal ValorEstipulado { get; set; }
        public decimal ValorFinal { get; set; }
        public DateTime DataDoRegistro { get; set; }

    }
}

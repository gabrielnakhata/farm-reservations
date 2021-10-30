using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizing_life.Entidades
{
    public class Estudo
    {
        public int Id { get; set; }
        public string Materia { get; set; }
        public string Tema { get; set; }
        public string Descricao { get; set; }
        public int TempoDeEstudo { get; set; }
        public int AvaliacaoPessoal { get; set; }
        public DateTime DataDoRegistro { get; set; }
        


    }
}

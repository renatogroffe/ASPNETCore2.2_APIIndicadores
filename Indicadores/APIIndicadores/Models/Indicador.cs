using System;

namespace APIIndicadores.Models
{
    public class Indicador
    {
        public string Sigla { get; set; }
        public string NomeIndicador { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        public decimal Valor { get; set; }
    }
}
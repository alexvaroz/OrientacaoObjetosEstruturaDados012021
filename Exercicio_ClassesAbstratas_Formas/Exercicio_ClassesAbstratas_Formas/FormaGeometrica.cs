using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ClassesAbstratas_Formas
{
    abstract class FormaGeometrica
    {
        protected FormaGeometrica(string descricao, int medida)
        {
            Medida = medida;
            Descricao = descricao;
        }

        public int Medida { get; set; }

        public string Descricao { get; set; }

        public abstract double CalcularPerimetro();

        public abstract double CalcularArea();
    }
}

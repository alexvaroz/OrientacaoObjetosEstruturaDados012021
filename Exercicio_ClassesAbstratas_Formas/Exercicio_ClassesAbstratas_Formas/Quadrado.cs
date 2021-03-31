using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ClassesAbstratas_Formas
{
    class Quadrado : FormaGeometrica
    {
        public Quadrado(string descricao, int medida) : base(descricao, medida)
        {
        }

        public override double CalcularArea()
        {
            return Medida * Medida;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Medida;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ClassesAbstratas_Formas
{
    class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(string descricao, int medida) : base(descricao, medida)
        {
        }

        public override double CalcularArea()
        {
           return Medida*Medida*Math.Sqrt(3)/4;
        }

        public override double CalcularPerimetro()
        {
            return 3 * Medida;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ClassesAbstratas_Formas
{
    class Hexagono : FormaGeometrica
    {
        public Hexagono(string descricao, int medida) : base(descricao, medida)
        {
        }

        public override double CalcularArea()
        {
            return 3 * (Medida * Medida) * Math.Sqrt(3) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 6 * Medida;
        }
    }
}

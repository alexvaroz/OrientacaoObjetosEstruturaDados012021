using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ClassesAbstratas_Formas
{
    class Circulo : FormaGeometrica
    {
        const double PI = 3.14;

        public Circulo(string descricao, int medida) : base(descricao, medida)
        {
        }

        public override double CalcularArea()
        {
            return Medida * Medida * PI;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Medida * PI;
        }
    }
}

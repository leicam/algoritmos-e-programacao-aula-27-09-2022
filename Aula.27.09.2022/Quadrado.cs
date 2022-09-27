using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula._27._09._2022
{
    public class Quadrado : AbstractFiguraGeometrica
    {
        public int Altura { get; set; }
        public int Largura { get; set; }

        public override int CalcularArea()
        {
            return Altura * Largura;
        }
    }
}
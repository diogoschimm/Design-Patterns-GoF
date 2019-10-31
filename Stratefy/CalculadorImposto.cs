using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.Stratefy
{
    public class CalculadorImposto
    {
        public double RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}

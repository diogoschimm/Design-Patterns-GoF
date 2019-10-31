using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.Stratefy
{
    public class ISS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}

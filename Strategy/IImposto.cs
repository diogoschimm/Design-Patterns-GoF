using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.Stratefy
{
   public interface IImposto
    {
        double Calcular(Orcamento orcamento);
    }
}

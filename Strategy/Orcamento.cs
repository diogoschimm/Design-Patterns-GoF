﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.Stratefy
{
    public class Orcamento
    {
        public double Valor { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
        }

    }
}

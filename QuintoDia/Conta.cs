﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoDia
{
    public class Conta
    {
        public Conta(string titular)
        {
            Titular = titular;
        }

        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
    }
}

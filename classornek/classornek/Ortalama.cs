﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classornek
{
    internal class Ortalama
    {
        double yazili1;
        double yazili2;
        double yazili3;

        public double Yazili1 { get => yazili1; set => yazili1 = value; }
        public double Yazili2 { get => yazili2; set => yazili2 = value; }
        public double Yazili3 { get => yazili3; set => yazili3 = value; }

        public Ortalama(double yazili1, double yazili2, double yazili3)
        {
            Yazili1 = yazili1;
            Yazili2 = yazili2;
            Yazili3 = yazili3;

             double OrtalamaHesapla()
            {
                double ortalama=(yazili1 + yazili2)/2;
                return ortalama;
            }
        }
    }
}

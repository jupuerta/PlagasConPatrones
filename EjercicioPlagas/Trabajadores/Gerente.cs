﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Trabajadores {
    [Serializable()]
    public class Gerente : ITrabajador {
        private double Ingreso { get; set; }

        public Gerente(double Ingresod) {
            Ingreso = Ingresod;
        }
        public double IngresoServicio() {
            return Ingreso;
        }
    }
}

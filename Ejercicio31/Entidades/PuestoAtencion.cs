﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return numeroActual++;
            }
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(3000);
            return true;
        }
    }

}

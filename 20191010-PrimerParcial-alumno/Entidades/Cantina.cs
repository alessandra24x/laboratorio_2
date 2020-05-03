using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;

        public Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        //public static Cantina GetCantina(int espacios)
        //{
        //    if (singleton is null)
        //    {
        //        singleton = new Cantina(espacios);
        //    }
        //    else
        //    {
        //        singleton.espaciosTotales = espacios;
        //    }
        //    return singleton;
        //}

        public static bool operator +(Cantina cantina, Botella botella)
        {
            if (!(cantina is null) || !(botella is null))
            {
                if (cantina.espaciosTotales > cantina.botellas.Count)
                {
                    cantina.botellas.Add(botella);
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Cantina c, Botella b)
        {
            if (!(c is null) || !(b is null))
                foreach (Botella botella in c.botellas)
                {
                    if (c.botellas.Contains(botella))
                        if (botella == b)
                            return true;
                }
            return false;
        }

        public static bool operator !=(Cantina c, Botella b)
        {
            return !(c == b);
        }

    }
}

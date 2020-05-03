using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Edificio
    {
        private const short limiteCantinas = 2;
        private Cantina[] cantinas;
        private static Edificio singleton;

        private Edificio()
        {
            cantinas = new Cantina[limiteCantinas];
        }

        static Edificio()
        {
            Edificio.singleton = new Edificio();
        }

        public static Edificio GetBar()
        {
            return singleton;
        }

        public static bool operator +(Edificio ed, Cantina c)
        {
            for (int i = 0; i < ed.cantinas.Length; i++)
            {
                if(ed.cantinas[i] == null)
                {
                    ed.cantinas[i] = c;
                    return true;
                }
            }
            return false;
        }
    }
}

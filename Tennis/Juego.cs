using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tennis
{
    public class Juego
    {
        public Juego(Jugador p1, Jugador p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        private Jugador p1 { get; set; }

        private Jugador p2 { get; set; }
    }
}

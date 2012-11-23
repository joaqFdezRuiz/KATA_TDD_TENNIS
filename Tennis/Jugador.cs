using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tennis
{
    public class Jugador
    {
        public Jugador() {
            puntos = "0";
        }

        public object ObtienePuntuacion()
        {
            return puntos;
        }

        private string puntos { get; set; }

        public void RealizaPunto()
        {
            throw new System.NotImplementedException();
        }
    }
}

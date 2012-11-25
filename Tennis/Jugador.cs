using System;

namespace Tennis
{
    public class Jugador : IJugador
    {
        public string puntos { get; set; }
        public IJuego game { get; set; }

        public Jugador() {
            puntos = "0";
        }

        public object DamePuntuacion()
        {
            return puntos;
        }

        public void Puntua()
        {
            game.Puntua(this);
        }
    }
}

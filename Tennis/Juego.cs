using System;

namespace Tennis
{
    public class Juego : IJuego
    {
        private string[] puntuaciones =
            new string[] { "0", "15", "30", "40", "IGUALES", "VENTAJA" };

        private IJugador p1;
        private IJugador p2;
        private IJugador ganador;

        private IJugador ObtieneOponente(IJugador player)
        {
            if (player == p1)
                return p2;
            return p1;
        }

        public Juego(IJugador p1, IJugador p2)
        {
            if (p1 == null || p2 == null)
            {
                throw new ArgumentException("Se necesitan 2 jugadores...");
            }
            this.p1 = p1;
            this.p2 = p2;
            p1.game = this;
            p2.game = this;
        }


        public void Puntua(IJugador player)
        {
            int i = Array.IndexOf(puntuaciones, player.puntos);
            if (i == 2)
            {
                IJugador oponente = ObtieneOponente(player);
                if (oponente.puntos == "40")
                {
                    oponente.puntos = "IGUALES";
                    player.puntos = "IGUALES";
                    return;
                }
            }

            if (i == 3 || i == 5)
            {
                IJugador oponente = ObtieneOponente(player);
                if (oponente.puntos == "VENTAJA")
                {
                    oponente.puntos = "IGUALES";
                    player.puntos = "IGUALES";
                    return;
                }

                ganador = player;
                return;
            }

            if (i == 4)
            {

                IJugador oponente = ObtieneOponente(player);

                if (oponente.puntos == "IGUALES")
                {
                    oponente.puntos = "IGUALES";
                    player.puntos = "VENTAJA";
                    return;
                }
            }
            player.puntos = puntuaciones[i + 1];
        }

        public object ObtieneGanador()
        {
            return ganador;
        }

    }
}
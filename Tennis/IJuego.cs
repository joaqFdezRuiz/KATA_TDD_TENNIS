using System;
namespace Tennis
{
    public interface IJuego
    {
        object ObtieneGanador();
        void Puntua(IJugador player);
    }
}

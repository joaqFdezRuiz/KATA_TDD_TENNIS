using System;
namespace Tennis
{
    public interface IJugador
    {
        object DamePuntuacion();
        IJuego game { get; set; }
        string puntos { get; set; }
        void Puntua();
    }
}

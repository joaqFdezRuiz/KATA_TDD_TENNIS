using System;
namespace Tennis
{
    public interface IJugador
    {
        object DamePuntuacion();
        Juego game { get; set; }
        string puntos { get; set; }
        void Puntua();
    }
}

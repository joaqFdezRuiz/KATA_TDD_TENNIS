using NUnit.Framework;
using Tennis;

namespace TennisTests
{
    public class TennisTests
    {
        [TestFixture]
        public class Player_P1_In_Player_P2_In
        {
            IJugador p1 = new Jugador();
            IJugador p2 = new Jugador();
            IJuego game;

            [SetUp]
            public void Setup()
            {
                game = new Juego(p1, p2);
            }

            [Test]
            public void P1_0_P2_0()
            {
                Assert.AreEqual("0", p1.DamePuntuacion());
                Assert.AreEqual("0", p2.DamePuntuacion());
            }
        }

        [TestFixture]
        public class Player_P1_15_Player_P2_0
        {
            IJugador p1 = new Jugador();
            IJugador p2 = new Jugador();
            IJuego game;

            [SetUp]
            public void Setup()
            {
                game = new Juego(p1, p2);
                p1.Puntua();
            }

            [Test]
            public void P1_15_P2_0()
            {
                Assert.AreEqual("15", p1.DamePuntuacion());
                Assert.AreEqual("0", p2.DamePuntuacion());
            }
        }

        [TestFixture]
        public class Player_P1_30_Player_P2_0
        {
            IJugador p1 = new Jugador();
            IJugador p2 = new Jugador();
            IJuego game;

            [SetUp]
            public void Setup()
            {
                game = new Juego(p1, p2);
                p1.Puntua();
                p1.Puntua();
            }

            [Test]
            public void P1_30_P2_0()
            {
                Assert.AreEqual("30", p1.DamePuntuacion());
                Assert.AreEqual("0", p2.DamePuntuacion());
            }
        }

        public class Player_P1_40_Player_P2_0
        {
            IJugador p1 = new Jugador();
            IJugador p2 = new Jugador();
            IJuego game;

            [SetUp]
            public void Setup()
            {
                game = new Juego(p1, p2);
                p1.Puntua();
                p1.Puntua();
                p1.Puntua();
            }

            [Test]
            public void P1_40_P2_0()
            {
                Assert.AreEqual("40", p1.DamePuntuacion());
                Assert.AreEqual("0", p2.DamePuntuacion());
            }
        }

        public class Player_P1_Gana
        {
            IJugador p1 = new Jugador();
            IJugador p2 = new Jugador();
            IJuego game;

            [SetUp]
            public void Setup()
            {
                game = new Juego(p1, p2);
                p1.Puntua();
                p1.Puntua();
                p1.Puntua();
                p1.Puntua();
            }

            [Test]
            public void P1_Gana()
            {
                Assert.AreEqual(p1, game.ObtieneGanador());
            }
        }

        public class Player_P2_Gana
        {
            IJugador p1 = new Jugador();
            IJugador p2 = new Jugador();
            IJuego game;

            [SetUp]
            public void Setup()
            {
                game = new Juego(p1, p2);
                p2.Puntua();
                p2.Puntua();
                p2.Puntua();
                p2.Puntua();
            }

            [Test]
            public void P2_Gana()
            {
                Assert.AreEqual(p2, game.ObtieneGanador());
            }
        }

        public class P1_P2_Iguales
        {
            IJugador p1 = new Jugador();
            IJugador p2 = new Jugador();
            IJuego game;

            [SetUp]
            public void Setup()
            {
                game = new Juego(p1, p2);
                p2.Puntua();
                p2.Puntua();
                p2.Puntua();
                p1.Puntua();
                p1.Puntua();
                p1.Puntua();
            }

            [Test]
            public void Iguales()
            {
                Assert.AreEqual("IGUALES", p1.DamePuntuacion());
                Assert.AreEqual("IGUALES", p2.DamePuntuacion());
            }
        }

        public class P1_VENTAJA
        {
            IJugador p1 = new Jugador();
            IJugador p2 = new Jugador();
            IJuego game;

            [SetUp]
            public void Setup()
            {
                game = new Juego(p1, p2);
                p2.Puntua();
                p2.Puntua();
                p2.Puntua();
                p1.Puntua();
                p1.Puntua();
                p1.Puntua();
                p1.Puntua();
            }

            [Test]
            public void Ventaja()
            {
                Assert.AreEqual("VENTAJA", p1.DamePuntuacion());
                Assert.AreEqual("IGUALES", p2.DamePuntuacion());
            }
        }

        public class P2_GANA_TRAS_VENTAJA
        {
            IJugador p1 = new Jugador();
            IJugador p2 = new Jugador();
            IJuego game;

            [SetUp]
            public void Setup()
            {
                game = new Juego(p1, p2);
                p1.Puntua();
                p1.Puntua();
                p1.Puntua();
                p2.Puntua();
                p2.Puntua();
                p2.Puntua();
                p2.Puntua();
                p2.Puntua();
            }

            [Test]
            public void Gana_Tras_Ventaja()
            {
                Assert.AreEqual(p2, game.ObtieneGanador());
            }
        }
    }

   
}

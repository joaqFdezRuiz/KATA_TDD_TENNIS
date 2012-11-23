using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Tennis;

namespace TennisTests
{
    public class TennisTests
    {
        [TestFixture]
        public class Comienza_El_Partido: Inicial {
            [SetUp]
            public void Setup() {
                p1 = new Jugador();
                p2 = new Jugador();
                juego = new Juego(p1, p2);
            }

            [Test]
            public void Test() {
                Assert.AreEqual("0", p1.ObtienePuntuacion());
                Assert.AreEqual("0", p2.ObtienePuntuacion());
            }
        }

        [TestFixture]
        public class Jugador_Uno_Hace_Punto : Inicial {
            [SetUp]
            public void Setup() {
                p1 = new Jugador();
                p2 = new Jugador();
                juego = new Juego(p1, p2);
                p1.RealizaPunto();
            }

            [Test]
            public void Test() {
                Assert.AreEqual("15", p1.ObtienePuntuacion());
            }
        }

        public class Inicial {
            protected Tennis.Jugador p1;
            protected Tennis.Jugador p2;
            protected Tennis.Juego juego;
        }

    }
}

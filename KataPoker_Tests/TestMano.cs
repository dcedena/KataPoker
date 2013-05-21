using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestMano
    {
        [Test]
        public void Test_CrearCartaAleatoria()
        {
            Carta carta = Carta.CrearCartaAleatoria();

        }

        [Test]
        public void Test_CrearManoAleatoria()
        {
            Mano mano = Mano.CrearManoAleatoria();

        }
    }
}

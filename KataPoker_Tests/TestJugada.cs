using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugada
    {
        #region Jugada - Carta más alta

        [Test]
        public void Test_ComprobarCartaMasAlta_01()
        {
            Mano mano = Manos.mano_01_Desordenada_Nada;
            Carta cartaMasAlta = mano.GetCartaMasAlta();

            Assert.AreEqual(Cards.C_CORA_Q, cartaMasAlta);
        }

        [Test]
        public void Test_ComprobarCartaMasAlta_02()
        {
            Mano mano = Manos.mano_02_Desordenada_Nada;
            Carta cartaMasAlta = mano.GetCartaMasAlta();

            Assert.AreEqual(Cards.C_TREB_AS, cartaMasAlta);
        }

        [Test]
        public void Test_ComprobarCartaMasAlta_03()
        {
            Mano mano = Manos.mano_03_Desordenada_Nada;
            Carta cartaMasAlta = mano.GetCartaMasAlta();

            Assert.AreEqual(Cards.C_TREB_AS, cartaMasAlta);
        }

        #endregion
    }
}

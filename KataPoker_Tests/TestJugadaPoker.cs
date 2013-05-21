using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugadaPoker
    {
        #region Jugada - Poker
        [Test]
        public void Test_JugadaPoker_EsPoker()
        {
            Mano mano = Manos.mano_08_Poker;

            Assert.IsTrue(mano.IsPoker());
        }

        [Test]
        public void Test_JugadaPoker_NoEsPareja()
        {
            Mano mano = Manos.mano_08_Poker;

            Assert.IsFalse(mano.IsPareja());
        }

        [Test]
        public void Test_JugadaPoker_NoEsDoblePareja()
        {
            Mano mano = Manos.mano_08_Poker;

            Assert.IsFalse(mano.IsDoblePareja());
        }

        [Test]
        public void Test_JugadaPoker_NoEsTrio()
        {
            Mano mano = Manos.mano_08_Poker;

            Assert.IsFalse(mano.IsTrio());
        }

        [Test]
        public void Test_JugadaPoker_NoEsEscalera()
        {
            Mano mano = Manos.mano_08_Poker;

            Assert.IsFalse(mano.IsEscalera());
        }

        [Test]
        public void Test_JugadaPoker_NoEsColor()
        {
            Mano mano = Manos.mano_08_Poker;

            Assert.IsFalse(mano.IsColor());
        }

        [Test]
        public void Test_JugadaPoker_NoEsFull()
        {
            Mano mano = Manos.mano_08_Poker;

            Assert.IsFalse(mano.IsFull());
        }

        [Test]
        public void Test_JugadaPoker_NoEsEscaleraColor()
        {
            Mano mano = Manos.mano_08_Poker;

            Assert.IsFalse(mano.IsEscaleraColor());
        }

        [Test]
        public void Test_JugadaPoker_NoEsEscaleraReal()
        {
            Mano mano = Manos.mano_08_Poker;

            Assert.IsFalse(mano.IsEscaleraReal());
        }
        #endregion
    }
}

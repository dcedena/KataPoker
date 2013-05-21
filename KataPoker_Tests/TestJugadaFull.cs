using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugadaFull
    {
        #region Jugada - Full
        [Test]
        public void Test_JugadaFull_EsFull()
        {
            Mano mano = Manos.mano_09_Full;

            Assert.IsTrue(mano.IsFull());
        }

        [Test]
        public void Test_JugadaFull_NoEsPareja()
        {
            Mano mano = Manos.mano_09_Full;

            Assert.IsFalse(mano.IsPareja());
        }

        [Test]
        public void Test_JugadaFull_NoEsDoblePareja()
        {
            Mano mano = Manos.mano_09_Full;

            Assert.IsFalse(mano.IsDoblePareja());
        }

        [Test]
        public void Test_JugadaFull_NoEsTrio()
        {
            Mano mano = Manos.mano_09_Full;

            Assert.IsFalse(mano.IsTrio());
        }

        [Test]
        public void Test_JugadaFull_NoEsEscalera()
        {
            Mano mano = Manos.mano_09_Full;

            Assert.IsFalse(mano.IsEscalera());
        }

        [Test]
        public void Test_JugadaFull_NoEsColor()
        {
            Mano mano = Manos.mano_09_Full;

            Assert.IsFalse(mano.IsColor());
        }

        [Test]
        public void Test_JugadaFull_NoEsPoker()
        {
            Mano mano = Manos.mano_09_Full;

            Assert.IsFalse(mano.IsPoker());
        }

        [Test]
        public void Test_JugadaFull_NoEsEscaleraColor()
        {
            Mano mano = Manos.mano_09_Full;

            Assert.IsFalse(mano.IsEscaleraColor());
        }

        [Test]
        public void Test_JugadaFull_NoEsEscaleraReal()
        {
            Mano mano = Manos.mano_09_Full;

            Assert.IsFalse(mano.IsEscaleraReal());
        }
        #endregion
    }
}

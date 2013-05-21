using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugadaDoblePareja
    {
        #region Jugada - Doble Pareja
        [Test]
        public void Test_JugadaDoblePareja_EsDoblePareja()
        {
            Mano mano = Manos.mano_10_DoblePareja;

            Assert.IsTrue(mano.IsDoblePareja());
        }

        [Test]
        public void Test_JugadaDoblePareja_NoEsPareja()
        {
            Mano mano = Manos.mano_10_DoblePareja;

            Assert.IsFalse(mano.IsPareja());
        }

        [Test]
        public void Test_JugadaDoblePareja_NoEsTrio()
        {
            Mano mano = Manos.mano_10_DoblePareja;

            Assert.IsFalse(mano.IsTrio());
        }

        [Test]
        public void Test_JugadaDoblePareja_NoEsEscalera()
        {
            Mano mano = Manos.mano_10_DoblePareja;

            Assert.IsFalse(mano.IsEscalera());
        }

        [Test]
        public void Test_JugadaDoblePareja_NoEsColor()
        {
            Mano mano = Manos.mano_10_DoblePareja;

            Assert.IsFalse(mano.IsColor());
        }

        [Test]
        public void Test_JugadaDoblePareja_NoEsFull()
        {
            Mano mano = Manos.mano_10_DoblePareja;

            Assert.IsFalse(mano.IsFull());
        }

        [Test]
        public void Test_JugadaDoblePareja_NoEsPoker()
        {
            Mano mano = Manos.mano_10_DoblePareja;

            Assert.IsFalse(mano.IsPoker());
        }

        [Test]
        public void Test_JugadaDoblePareja_NoEsEscaleraColor()
        {
            Mano mano = Manos.mano_10_DoblePareja;

            Assert.IsFalse(mano.IsEscaleraColor());
        }

        [Test]
        public void Test_JugadaDoblePareja_NoEsEscaleraReal()
        {
            Mano mano = Manos.mano_10_DoblePareja;

            Assert.IsFalse(mano.IsEscaleraReal());
        }
        #endregion
    }
}

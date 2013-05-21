using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugadaEscalera
    {
        #region Jugada - Escalera
        [Test]
        public void Test_JugadaEscalera_EsEscalera()
        {
            Mano mano = Manos.mano_12_Escalera;

            Assert.IsTrue(mano.IsEscalera());
        }

        [Test]
        public void Test_JugadaEscalera_NoEsPareja()
        {
            Mano mano = Manos.mano_12_Escalera;

            Assert.IsFalse(mano.IsPareja());
        }

        [Test]
        public void Test_JugadaEscalera_NoEsDoblePareja()
        {
            Mano mano = Manos.mano_12_Escalera;

            Assert.IsFalse(mano.IsDoblePareja());
        }

        [Test]
        public void Test_JugadaEscalera_NoEsTrio()
        {
            Mano mano = Manos.mano_12_Escalera;

            Assert.IsFalse(mano.IsTrio());
        }

        [Test]
        public void Test_JugadaEscalera_NoEsColor()
        {
            Mano mano = Manos.mano_12_Escalera;

            Assert.IsFalse(mano.IsColor());
        }

        [Test]
        public void Test_JugadaEscalera_NoEsFull()
        {
            Mano mano = Manos.mano_12_Escalera;

            Assert.IsFalse(mano.IsFull());
        }

        [Test]
        public void Test_JugadaEscalera_NoEsPoker()
        {
            Mano mano = Manos.mano_12_Escalera;

            Assert.IsFalse(mano.IsPoker());
        }

        [Test]
        public void Test_JugadaEscalera_NoEsEscaleraColor()
        {
            Mano mano = Manos.mano_12_Escalera;

            Assert.IsFalse(mano.IsEscaleraColor());
        }

        [Test]
        public void Test_JugadaEscalera_NoEsEscaleraReal()
        {
            Mano mano = Manos.mano_12_Escalera;

            Assert.IsFalse(mano.IsEscaleraReal());
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugadaEscaleraColor
    {
        #region Jugada - EscaleraColor
        #region Functions - Is
        [Test]
        public void Test_JugadaEscaleraColor_EsEscaleraColor()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.IsTrue(mano.IsEscaleraColor());
        }

        [Test]
        public void Test_JugadaEscaleraColor_NoEsPareja()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.IsFalse(mano.IsPareja());
        }

        [Test]
        public void Test_JugadaEscaleraColor_NoEsDoblePareja()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.IsFalse(mano.IsDoblePareja());
        }

        [Test]
        public void Test_JugadaEscaleraColor_NoEsTrio()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.IsFalse(mano.IsTrio());
        }

        [Test]
        public void Test_JugadaEscaleraColor_NoEsEscalera()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.IsFalse(mano.IsEscalera());
        }

        [Test]
        public void Test_JugadaEscaleraColor_NoEsColor()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.IsFalse(mano.IsColor());
        }

        [Test]
        public void Test_JugadaEscaleraColor_NoEsFull()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.IsFalse(mano.IsFull());
        }

        [Test]
        public void Test_JugadaEscaleraColor_NoEsPoker()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.IsFalse(mano.IsPoker());
        }

        [Test]
        public void Test_JugadaEscaleraColor_NoEsEscaleraReal()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.IsFalse(mano.IsEscaleraReal());
        }
        #endregion

        #region Function - GetJugada()
        [Test]
        public void Test_JugadaEscaleraColor_EsEscaleraColor_GetJugada()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.AreEqual(JugadaMano.ESCALERA_COLOR, mano.GetJugada());
        }

        [Test]
        public void Test_JugadaEscaleraColor_NoEsEscalera_GetJugada()
        {
            Mano mano = Manos.mano_13_EscaleraColor;

            Assert.AreNotEqual(JugadaMano.ESCALERA, mano.GetJugada());
        }



        #endregion

        #endregion
    }
}

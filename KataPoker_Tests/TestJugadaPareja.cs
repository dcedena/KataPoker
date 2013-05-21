using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugadaPareja
    {
        #region Jugada - Pareja
        #region Functions - Is
        [Test]
        public void Test_JugadaPareja_EsPareja()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.IsTrue(mano.IsPareja());
        }

        [Test]
        public void Test_JugadaPareja_NoEsDoblePareja()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.IsTrue(mano.IsPareja());
        }

        [Test]
        public void Test_JugadaPareja_NoEsTrio()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.IsFalse(mano.IsTrio());
        }

        [Test]
        public void Test_JugadaPareja_NoEsEscalera()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.IsFalse(mano.IsEscalera());
        }

        [Test]
        public void Test_JugadaPareja_NoEsColor()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.IsFalse(mano.IsColor());
        }

        [Test]
        public void Test_JugadaPareja_NoEsFull()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.IsFalse(mano.IsFull());
        }

        [Test]
        public void Test_JugadaPareja_NoEsPoker()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.IsFalse(mano.IsFull());
        }

        [Test]
        public void Test_JugadaPareja_NoEsEscaleraColor()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.IsFalse(mano.IsEscaleraColor());
        }

        [Test]
        public void Test_JugadaPareja_NoEsEscaleraReal()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.IsFalse(mano.IsEscaleraReal());
        }
        #endregion

        #region Function - GetJugada()
        [Test]
        public void Test_JugadaPareja_EsPareja_GetJugada()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.AreEqual(JugadaMano.PAREJA, mano.GetJugada());
        }

        [Test]
        public void Test_JugadaPareja_NoEsDoblePareja_GetJugada()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.AreNotEqual(JugadaMano.DOBLE_PAREJA, mano.GetJugada());
        }

        [Test]
        public void Test_JugadaPareja_NoEsTrio_GetJugada()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.AreNotEqual(JugadaMano.TRIO, mano.GetJugada());
        }

        [Test]
        public void Test_JugadaPareja_NoEsEscalera_GetJugada()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.AreNotEqual(JugadaMano.ESCALERA, mano.GetJugada());
        }

        [Test]
        public void Test_JugadaPareja_NoEsColor_GetJugada()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.AreNotEqual(JugadaMano.COLOR, mano.GetJugada());
        }

        [Test]
        public void Test_JugadaPareja_NoEsFull_GetJugada()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.AreNotEqual(JugadaMano.FULL, mano.GetJugada());
        }

        [Test]
        public void Test_JugadaPareja_NoEsPoker_GetJugada()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.AreNotEqual(JugadaMano.POKER, mano.GetJugada());
        }

        [Test]
        public void Test_JugadaPareja_NoEsEscaleraColor_GetJugada()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.AreNotEqual(JugadaMano.ESCALERA_COLOR, mano.GetJugada());
        }

        [Test]
        public void Test_JugadaPareja_NoEsEscaleraReal_GetJugada()
        {
            Mano mano = Manos.mano_06_Pareja;

            Assert.AreNotEqual(JugadaMano.ESCALERA_REAL, mano.GetJugada());
        }
        #endregion
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugadaTrio
    {
        #region Jugada - Trio
        #region Functions - Is
        [Test]
        public void Test_JugadaTrio_EsTrio()
        {
            Mano mano = Manos.mano_07_Trio;

            Assert.IsTrue(mano.IsTrio());
        }

        [Test]
        public void Test_JugadaTrio_NoEsPareja()
        {
            Mano mano = Manos.mano_07_Trio;

            Assert.IsFalse(mano.IsPareja());
        }

        [Test]
        public void Test_JugadaTrio_NoEsDoblePareja()
        {

        }

        [Test]
        public void Test_JugadaTrio_NoEsEscalera()
        {
            Mano mano = Manos.mano_07_Trio;

            Assert.IsFalse(mano.IsEscalera());
        }

        [Test]
        public void Test_JugadaTrio_NoEsColor()
        {
            Mano mano = Manos.mano_07_Trio;

            Assert.IsFalse(mano.IsColor());
        }

        [Test]
        public void Test_JugadaTrio_NoEsFull()
        {
            Mano mano = Manos.mano_07_Trio;

            Assert.IsFalse(mano.IsFull());
        }

        [Test]
        public void Test_JugadaTrio_NoEsPoker()
        {
            Mano mano = Manos.mano_07_Trio;

            Assert.IsFalse(mano.IsPoker());
        }

        [Test]
        public void Test_JugadaTrio_NoEsEscaleraColor()
        {
            Mano mano = Manos.mano_07_Trio;

            Assert.IsFalse(mano.IsEscaleraColor());
        }

        [Test]
        public void Test_JugadaTrio_NoEsEscaleraReal()
        {
            Mano mano = Manos.mano_07_Trio;

            Assert.IsFalse(mano.IsEscaleraReal());
        }
        #endregion

        #region Function - GetJugada()
        [Test]
        public void Test_JugadaTrio_EsTrio_GetJugada()
        {
            Mano mano = Manos.mano_07_Trio;

            Assert.AreEqual(JugadaMano.TRIO, mano.GetJugada());
        }

        #endregion
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugadaColor
    {
        #region Jugada - Color
        [Test]
        public void Test_JugadaColor_EsColor()
        {
            Mano mano = Manos.mano_11_Color_Treboles;

            Assert.IsTrue(mano.IsColor());
        }

        [Test]
        public void Test_JugadaColor_NoEsPareja()
        {
            Mano mano = Manos.mano_11_Color_Treboles;

            Assert.IsFalse(mano.IsPareja());
        }

        [Test]
        public void Test_JugadaColor_NoEsDoblePareja()
        {
            Mano mano = Manos.mano_11_Color_Treboles;

            Assert.IsFalse(mano.IsDoblePareja());
        }

        [Test]
        public void Test_JugadaColor_NoEsTrio()
        {
            Mano mano = Manos.mano_11_Color_Treboles;

            Assert.IsFalse(mano.IsTrio());
        }

        [Test]
        public void Test_JugadaColor_NoEsEscalera()
        {
            Mano mano = Manos.mano_11_Color_Treboles;

            Assert.IsFalse(mano.IsEscalera());
        }

        [Test]
        public void Test_JugadaColor_NoEsFull()
        {
            Mano mano = Manos.mano_11_Color_Treboles;

            Assert.IsFalse(mano.IsFull());
        }

        [Test]
        public void Test_JugadaColor_NoEsPoker()
        {
            Mano mano = Manos.mano_11_Color_Treboles;

            Assert.IsFalse(mano.IsPoker());
        }

        [Test]
        public void Test_JugadaColor_NoEsEscaleraColor()
        {
            Mano mano = Manos.mano_11_Color_Treboles;

            Assert.IsFalse(mano.IsEscaleraColor());
        }
        
        [Test]
        public void Test_JugadaColor_NoEsEscaleraReal()
        {
            Mano mano = Manos.mano_11_Color_Treboles;

            Assert.IsFalse(mano.IsEscaleraReal());
        }

        #endregion
    }
}

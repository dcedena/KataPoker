using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestJugadaEscaleraReal
    {
        #region Jugada - Escalera Real
        #region Functions - Is
        [Test]
        public void Test_JugadaEscaleraReal_EsEscaleraReal()
        {
            Mano mano = Manos.mano_14_EscaleraReal;

            Assert.IsTrue(mano.IsEscaleraReal());
        }

        #endregion

        #region Function - GetJugada()
        [Test]
        public void Test_JugadaEscaleraReal_EsEscaleraReal_GetJugada()
        {
            Mano mano = Manos.mano_14_EscaleraReal;

            Assert.AreEqual(JugadaMano.ESCALERA_REAL, mano.GetJugada());
        }
        #endregion
        #endregion
    }
}

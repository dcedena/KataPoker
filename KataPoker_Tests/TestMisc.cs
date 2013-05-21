using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KataPoker_Model;
using NUnit.Framework;

namespace KataPoker_Tests
{
    [TestFixture]
    public class TestMisc
    {
        [Test]
        public void Test_CrearCarta_ComprobarPalo()
        {
            Carta carta = new Carta(Cards.C_DIAM_4);

            Assert.AreEqual(PaloCarta.DIAMANTES, carta.Palo);
        }

        [Test]
        public void Test_CrearCarta_ComprobarValor()
        {
            Carta carta = new Carta(Cards.C_DIAM_4);

            Assert.AreEqual(ValorCarta.CUATRO, carta.Valor);
        }

        [Test]
        public void Test_ComprobarCarta_Correcto()
        {
            Carta carta = Cards.C_CORA_10;

            Assert.IsTrue(carta.Equals(Cards.C_CORA_10));
        }

        [Test]
        public void Test_ComprobarCarta_Incorrecto()
        {
            Carta carta = Cards.C_CORA_8;

            Assert.IsFalse(carta.Equals(Cards.C_CORA_10));
        }

        [Test]
        public void Test_ComprobarSiDosManosSonIguales()
        {
            Mano mano1 = Manos.mano_03_Ordenada_Nada;
            Mano mano2 = Manos.mano_03_Desordenada_Nada;

            bool sonIguales = mano1.Equals(mano2);

            Assert.IsTrue(sonIguales);
        }

        [Test]
        public void Test_ComprobarManoOrdenada_01()
        {
            Mano mano = Manos.mano_01_Desordenada_Nada;
            mano.OrdenarCartas();

            Assert.IsTrue(mano.Equals(Manos.mano_01_Ordenada_Nada));
        }

        [Test]
        public void Test_ComprobarManoOrdenada_02()
        {
            Mano mano = Manos.mano_02_Desordenada_Nada;
            mano.OrdenarCartas();

            Assert.IsTrue(mano.Equals(Manos.mano_02_Ordenada_Nada));
        }

        [Test]
        public void Test_ComprobarManoOrdenada_03()
        {
            Mano mano = Manos.mano_03_Desordenada_Nada;
            mano.OrdenarCartas();

            Assert.IsTrue(mano.Equals(Manos.mano_03_Ordenada_Nada));
        }

        [Test, Description("Este test se puede eliminar la función se usa en el constructor, y si hay repetidas, se la lanza una exception.")]
        public void Test_ComprobarSiHayCartasRepetidas_NoRepetidas_01()
        {
            Mano mano = new Mano(Cards.C_CORA_3, Cards.C_CORA_9, Cards.C_DIAM_5, Cards.C_DIAM_3, Cards.C_DIAM_2);

            Assert.IsFalse(mano.HayCartasRepetidas());
        }

        [Test]
        public void Test_ComprobarSiHayCartasRepetidas_NoRepetidas_02()
        {
            Mano mano = new Mano(Cards.C_CORA_3, Cards.C_CORA_5, Cards.C_DIAM_5, Cards.C_DIAM_3, Cards.C_DIAM_2);

            Assert.IsFalse(mano.HayCartasRepetidas());
        }

        [Test]
        [ExpectedException("System.ArgumentException")]
        public void Test_Exception_CrearManoConCartasRepetidas_01()
        {
            Mano mano = new Mano(Cards.C_CORA_3, Cards.C_CORA_3, Cards.C_DIAM_5, Cards.C_DIAM_3, Cards.C_DIAM_2);

        }

        [Test]
        [ExpectedException("System.ArgumentException")]
        public void Test_Exception_CrearManoConCartasRepetidas_02()
        {
            Mano mano = new Mano(Cards.C_CORA_3, Cards.C_CORA_5, Cards.C_DIAM_5, Cards.C_DIAM_3, Cards.C_DIAM_5);

        }

        [Test]
        public void Test_AgruparValoresDeCartas()
        {
            Mano mano = Manos.mano_01_Desordenada_Nada;

            Dictionary<ValorCarta, int> grupoValores = mano.GetCartasAgrupadasPorValor();

            //Assert.AreEqual(grupoValores[ValorCarta.TRES], 1);

            // -- Cualquiera de los siguientes Assert valen.
            // Assert.AreEqual(grupoValores[ValorCarta.QUEEN], 1);
            // Assert.AreEqual(grupoValores[ValorCarta.SIETE], 1);
            Assert.AreEqual(grupoValores[ValorCarta.DOS], 1);

            // -- Si se indica un ValorCarta Inexistente, salta la exception: 'System.Collections.Generic.KeyNotFoundException ' 
            // Assert.AreNotEqual(grupoValores[ValorCarta.CINCO], 2);
        }
    }
}

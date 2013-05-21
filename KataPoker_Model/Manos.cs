using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataPoker_Model
{
    public class Manos
    {
        public static Mano mano_01_Ordenada_Nada = new Mano(Cards.C_PICA_2, Cards.C_DIAM_3, Cards.C_PICA_7, Cards.C_CORA_9, Cards.C_CORA_Q);
        public static Mano mano_01_Desordenada_Nada = new Mano(Cards.C_DIAM_3, Cards.C_CORA_Q, Cards.C_PICA_7, Cards.C_PICA_2, Cards.C_CORA_9);

        public static Mano mano_02_Ordenada_Nada = new Mano(Cards.C_TREB_AS, Cards.C_CORA_2, Cards.C_DIAM_5, Cards.C_CORA_6, Cards.C_CORA_9);
        public static Mano mano_02_Desordenada_Nada = new Mano(Cards.C_CORA_6, Cards.C_CORA_2, Cards.C_TREB_AS, Cards.C_DIAM_5, Cards.C_CORA_9);

        public static Mano mano_03_Ordenada_Nada =    new Mano(Cards.C_TREB_AS, Cards.C_CORA_2, Cards.C_PICA_3, Cards.C_DIAM_5, Cards.C_CORA_9);
        public static Mano mano_03_Desordenada_Nada = new Mano(Cards.C_CORA_2, Cards.C_DIAM_5, Cards.C_TREB_AS, Cards.C_CORA_9, Cards.C_PICA_3);

        public static Mano mano_05_Ordenada_Escalera = new Mano(Cards.C_DIAM_AS, Cards.C_CORA_2, Cards.C_TREB_3, Cards.C_DIAM_4, Cards.C_CORA_5);

        public static Mano mano_06_Pareja = new Mano(Cards.C_CORA_6, Cards.C_CORA_2, Cards.C_TREB_6, Cards.C_CORA_3, Cards.C_CORA_9);

        public static Mano mano_07_Trio = new Mano(Cards.C_CORA_6, Cards.C_CORA_2, Cards.C_TREB_6, Cards.C_DIAM_6, Cards.C_PICA_9);

        public static Mano mano_08_Poker = new Mano(Cards.C_CORA_6, Cards.C_CORA_2, Cards.C_TREB_6, Cards.C_DIAM_6, Cards.C_PICA_6);

        public static Mano mano_09_Full = new Mano(Cards.C_PICA_4, Cards.C_CORA_4, Cards.C_DIAM_4, Cards.C_DIAM_Q, Cards.C_TREB_Q);

        public static Mano mano_10_DoblePareja = new Mano(Cards.C_DIAM_2, Cards.C_CORA_2, Cards.C_DIAM_4, Cards.C_CORA_4, Cards.C_TREB_5);

        public static Mano mano_11_Color_Treboles = new Mano(Cards.C_TREB_5, Cards.C_TREB_3, Cards.C_TREB_10, Cards.C_TREB_AS, Cards.C_TREB_J);

        public static Mano mano_12_Escalera = new Mano(Cards.C_PICA_5, Cards.C_DIAM_3, Cards.C_DIAM_6, Cards.C_TREB_2, Cards.C_CORA_4);

        public static Mano mano_13_EscaleraColor = new Mano(Cards.C_PICA_5, Cards.C_PICA_3, Cards.C_PICA_6, Cards.C_PICA_2, Cards.C_PICA_4);

        public static Mano mano_14_EscaleraReal = new Mano(Cards.C_TREB_AS, Cards.C_TREB_K, Cards.C_TREB_Q, Cards.C_TREB_J, Cards.C_TREB_10);
    }       
}

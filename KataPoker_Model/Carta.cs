using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataPoker_Model
{
    public class Carta : ICloneable
    {
        public ValorCarta Valor { get; set; }
        public PaloCarta Palo { get; set; }

        public Carta(ValorCarta valor, PaloCarta palo)
        {
            this.Valor = valor;
            this.Palo = palo;
        }

        public Carta(Carta carta)
        {
            this.Valor = carta.Valor;
            this.Palo = carta.Palo;
        }

        public Carta()
        {
            // TODO: Complete member initialization
        }

        public override bool Equals(object obj)
        {
            Carta carta = (Carta)obj;
            return ((Palo == carta.Palo) && (Valor == carta.Valor));
        }

        public override string ToString()
        {
            return "[" + Valor.ToString() + "_" + Palo.ToString() + "]";
        }

        public object Clone()
        {
            Carta carta = new Carta();

            carta.Valor = this.Valor;
            carta.Palo = this.Palo;

            return carta;
        }

        public static Carta CrearCartaAleatoria()
        {
            int countValor = Enum.GetNames(typeof(ValorCarta)).Length;
            int countPalo = Enum.GetNames(typeof(PaloCarta)).Length;

            Random randomValor = new Random(DateTime.Now.Millisecond);
            Random randomPalo = new Random(DateTime.Now.Millisecond);

            int numValor = randomValor.Next(1, countValor);
            int numPalo = randomValor.Next(1, countPalo);

            Carta carta = new Carta( (ValorCarta)numValor, (PaloCarta)numPalo);

            return carta;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataPoker_Model
{
    public class Mano
    {
        public List<Carta> Cartas; 

        private JugadaMano _jugada = JugadaMano.NADA; 

        public Mano()
        {
            this.Cartas = new List<Carta>();
        }

        public Mano(Carta carta_1, Carta carta_2, Carta carta_3, Carta carta_4, Carta carta_5) : this()
        {
            Cartas.Add(carta_1);
            Cartas.Add(carta_2);
            Cartas.Add(carta_3);
            Cartas.Add(carta_4);
            Cartas.Add(carta_5);
            if(HayCartasRepetidas())
                throw new ArgumentException("Hay cartas repetidas.");

            this._jugada = GetJugada();
        }

        public Mano(List<Carta> listaCartas) :this(listaCartas[0], listaCartas[1], listaCartas[2], listaCartas[3], listaCartas[4])
        {

        }

        public bool HayCartasRepetidas()
        {
            bool hayRepetidas = false;
            for(int i=0;i<this.Cartas.Count;i++)
            {
                for(int j=0;j<this.Cartas.Count;j++)
                {
                    if((i != j) && (this.Cartas[i].Equals(this.Cartas[j])))
                    {
                        hayRepetidas = true;
                        break;
                    }
                }
                if (hayRepetidas)
                    break;
            }
            return hayRepetidas;
        }

        public void OrdenarCartas()
        {
            for(int i=0;i<this.Cartas.Count;i++)
            {
                for (int j =i+1; j < this.Cartas.Count; j++)
                {
                    int indI = (int)this.Cartas[i].Valor;
                    int indJ = (int)this.Cartas[j].Valor;

                    if(indJ < indI)
                    {
                        Carta cartaAux = this.Cartas[i];
                        this.Cartas[i] = this.Cartas[j];
                        this.Cartas[j] = cartaAux;
                    }
                }
            }
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (!(obj is Mano)))
                return false;

            Mano mano = (Mano) obj;
            this.OrdenarCartas();
            mano.OrdenarCartas();

            if (this.Cartas.Count != mano.Cartas.Count)
                return false;

            bool areEqual = false;
            for (int i = 0; i < this.Cartas.Count; i++)
            {
                if (!this.Cartas[i].Equals(mano.Cartas[i]))
                    break;
                else
                    areEqual = true;
            }
            return areEqual;
        }

        public Carta GetCartaMasAlta()
        {
            Carta cartaAlta = new Carta();
            if(this.Cartas.Count != 0)
            {
                this.OrdenarCartas();
                if (this.Cartas[0].Valor == ValorCarta.AS)
                    cartaAlta = this.Cartas[0];
                else
                    cartaAlta = this.Cartas[this.Cartas.Count - 1];
            }
            return cartaAlta;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Cartas.Count;i++ )
            {
                result += Cartas[i].ToString();

                if (i < Cartas.Count)
                    result += "-";
            }

            return result;
        }

        #region FUNCTIONS - Comprobar Jugadas
        private bool _isPareja()
        {
            Dictionary<ValorCarta, int> countValores = GetCartasAgrupadasPorValor();
            // Si alguno de los agrupados tiene count=2 y hay 4 elementos ValorCarta, solo tienen count 1.
            return (countValores.ContainsValue(2)) && (countValores.Count == 4);
        }

        public bool IsPareja()
        {
            return (this._jugada == JugadaMano.PAREJA);
        }

        private bool _isDoblePareja()
        {
            Dictionary<ValorCarta, int> countValores = GetCartasAgrupadasPorValor();
            // Si alguno de los agrupados tiene count=2, otro count=1 y hay 3 elementos.
            return (countValores.ContainsValue(2)) && (countValores.ContainsValue(1)) && (countValores.Count == 3);
        }

        public bool IsDoblePareja()
        {
            return (this._jugada == JugadaMano.DOBLE_PAREJA);
        }

        private bool _isTrio()
        {
            Dictionary<ValorCarta, int> countValores = GetCartasAgrupadasPorValor();
            // Si alguno de los agrupados tiene count=3 y hay 3 elementos ValorCarta, solo tienen count 1.
            return (countValores.ContainsValue(3)) && (countValores.Count == 3);
        }
        
        public bool IsTrio()
        {
            return (this._jugada == JugadaMano.TRIO);
        }

        private bool _isEscalera()
        {
            #region Is Escalera
            this.OrdenarCartas();

            bool sonConsecutivos = true;
            for (int i = 1; i < this.Cartas.Count; i++)
            {
                int indI_1 = (int) this.Cartas[i - 1].Valor;
                int indI = (int) this.Cartas[i].Valor;

                if (indI_1 != indI - 1)
                {
                    sonConsecutivos = false;
                    break;
                }
            }
            return sonConsecutivos;
            #endregion
        }

        public bool IsEscalera()
        {
            return (this._jugada == JugadaMano.ESCALERA);
        }

        private bool _isColor()
        {
            Dictionary<PaloCarta, int> countPalos = GetCartasAgrupadasPorPalo();
            // Si alguno de los agrupados tiene count=3 y hay 3 elementos ValorCarta, solo tienen count 1.
            return (countPalos.ContainsValue(5));
        }

        public bool IsColor()
        {
            return (this._jugada == JugadaMano.COLOR);
        }

        private bool _isFull()
        {
            Dictionary<ValorCarta, int> countValores = GetCartasAgrupadasPorValor();
            // Si uno de los agrupados tiene count=3 y otro count=2, hay dos grupos solamente.
            return (countValores.ContainsValue(3)) && (countValores.ContainsValue(2));
        }

        public bool IsFull()
        {
            return (this._jugada == JugadaMano.FULL);
        }

        private bool _isPoker()
        {
            Dictionary<ValorCarta, int> countValores = GetCartasAgrupadasPorValor();
            // Si alguno de los agrupados tiene count=4 y hay 2 elementos ValorCarta, solo tienen count 1.
            return (countValores.ContainsValue(4)) && (countValores.Count == 2);
        }

        public bool IsPoker()
        {
            return (this._jugada == JugadaMano.POKER);
        }

        private bool _isEscaleraColor()
        {
            return (this._isColor() && (this._isEscalera()));
        }

        public bool IsEscaleraColor()
        {
            return (this._jugada == JugadaMano.ESCALERA_COLOR);
        }

        private bool _isEscaleraReal()
        {
            this.OrdenarCartas();

            bool isResult = false;
            bool isColor = this._isColor();
            if ((isColor) && (Cartas[0].Valor == ValorCarta.AS) && (Cartas[1].Valor == ValorCarta.DIEZ) &&
                (Cartas[2].Valor == ValorCarta.JACK) && (Cartas[3].Valor == ValorCarta.QUEEN) &&
                (Cartas[4].Valor == ValorCarta.KING))
            {
                isResult = true;
            }

            return isResult;
        }

        public bool IsEscaleraReal()
        {
            return (this._jugada == JugadaMano.ESCALERA_REAL);
        }

        public JugadaMano GetJugada()
        {
            JugadaMano jugada = JugadaMano.NADA;
            this.OrdenarCartas();

            if(this._isEscaleraReal())
                jugada = JugadaMano.ESCALERA_REAL;
            else if(this._isEscaleraColor())
                jugada = JugadaMano.ESCALERA_COLOR;
            else if(this._isPoker())
                jugada = JugadaMano.POKER;
            else if(this._isFull())
                jugada = JugadaMano.FULL;
            else if (this._isColor())
                jugada = JugadaMano.COLOR;
            else if (this._isEscalera())
                jugada = JugadaMano.ESCALERA;
            else if (this._isTrio())
                jugada = JugadaMano.TRIO;
            else if (this._isDoblePareja())
                jugada = JugadaMano.DOBLE_PAREJA;
            else if (this._isPareja())
                jugada = JugadaMano.PAREJA;

            return jugada;
        }
        #endregion

        /// <summary>
        /// Agrupar Valores de las cartas, Key=ValorDeCarta, Value=Cuantos CINCOS, Cuantos CUATROS, Cuantos KINGS
        /// </summary>
        public Dictionary<ValorCarta, int> GetCartasAgrupadasPorValor()
        {
            Dictionary<ValorCarta, int> valores = new Dictionary<ValorCarta, int>();

            foreach (Carta carta in this.Cartas)
            {
                if (valores.ContainsKey(carta.Valor))
                    valores[carta.Valor]++;
                else
                    valores.Add(carta.Valor, 1);
            }

            return valores;
        }

        /// <summary>
        /// Agrupar Valores de las cartas, Key=PaloCarta, Value=Cuantos TREBOLES, Cuantos DIAMANTES
        /// </summary>
        public Dictionary<PaloCarta, int> GetCartasAgrupadasPorPalo()
        {
            Dictionary<PaloCarta, int> valores = new Dictionary<PaloCarta, int>();

            foreach (Carta carta in this.Cartas)
            {
                if (valores.ContainsKey(carta.Palo))
                    valores[carta.Palo]++;
                else
                    valores.Add(carta.Palo, 1);
            }

            return valores;
        }

        public static Mano CrearManoAleatoria()
        {
            List<Carta> cartas = new List<Carta>();
            do
            {
                Carta carta = Carta.CrearCartaAleatoria();

                if(!cartas.Contains(carta))
                    cartas.Add(carta);

            } while (cartas.Count < 5);

            Mano mano = new Mano(cartas);

            return mano;
        }
    }
}

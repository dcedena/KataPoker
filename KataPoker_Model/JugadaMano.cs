using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataPoker_Model
{
    /////////////////////////////////////////////////////
    /* Más Info: http://www.poquer.com.es/ranking.html */
    /////////////////////////////////////////////////////
    
    public enum JugadaMano
    {
        NADA = 0,
        CARTA_ALTA = 1,
        PAREJA = 2,
        DOBLE_PAREJA = 3,
        TRIO = 4,
        ESCALERA = 5,
        COLOR = 6,
        FULL = 7,
        POKER = 8,
        ESCALERA_COLOR = 9,
        ESCALERA_REAL = 10,
    }
}

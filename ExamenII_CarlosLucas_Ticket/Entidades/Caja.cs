using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Caja
    {
        public int IdRecibo { get; set; }
        public int IdTicket { get; set; }

        public Caja()
        {
        }

        public Caja(int idRecibo, int idTicket)
        {
            IdRecibo = idRecibo;
            IdTicket = idTicket;
        }
    }
}

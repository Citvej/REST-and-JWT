using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rain51.Controllers
{
    public class Novice
    {
        public int NoviceId { get; set; }
        public DateTime datum { get; set; }
        public string avtor { get; set; }
        public string besedilo { get; set; }

        public Novice(int noviceId, string avtor, string besedilo)
        {
            this.NoviceId = noviceId;
            this.datum = DateTime.Now;
            this.avtor = avtor;
            this.besedilo = besedilo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Roulette.Entities
{
    public class OnlineTable
    {
        [Key]
        public int Id { get; set; }
        public string _State { get; set; }
        public string Bet { get; set; }
        public int Quantity { get; set; }

    }
}

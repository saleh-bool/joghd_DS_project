using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.Model
{
    public class Transaction
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Id { get; set; }
        public string TransactionsTime { get; set; }
        public string Price { get; set; }
    }
}

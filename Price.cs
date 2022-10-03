using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2
{
    internal class Price
    {
        public int[] price = { 10, 7, 11, 15 };
        private int orderAmount = 0;
        private int totalAmount = 0;
        public Price()
        {

        }
        public int OrderAmount { get => orderAmount; set => orderAmount = value; }
        public int TotalAmount { get => totalAmount; set => totalAmount = value; }
    }
}
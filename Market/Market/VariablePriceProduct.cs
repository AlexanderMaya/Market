using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            decimal price = 0;
            price = Price * (decimal)Quantity;
            return price * (decimal)Tax + price;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeasurement: {Measurement}" +
                $"\n\tQuantity...: {$"{Quantity:N2}", 18}" +
                $"\n\tValue......: {$"{ValueToPay():C2}",18}";
        }
    }
}

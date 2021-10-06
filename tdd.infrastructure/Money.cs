using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.infrastructure
{
    public class Money
    {
        protected string _currency;
        protected int amount;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            _currency = currency;
        }

        public Money times(int multiplier)
        {
            return new Money(amount * multiplier, _currency);
        }
        public string currency()
        {
            return _currency;
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && currency().Equals(money.currency());
        }

        public override string ToString()
        {
            return amount + " " + _currency;
        }


        public static Money dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}

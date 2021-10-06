using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.infrastructure
{
    public abstract class Money
    {
        protected int amount;
        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && this.GetType() == money.GetType();
        }

        public abstract Money times(int multiplier);

        public static Money dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money franc(int amount)
        {
            return new Franc(amount);
        }
    }
}

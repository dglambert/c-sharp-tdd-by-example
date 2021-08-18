using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.infrastructure
{
    public class Money
    {
        protected int amount;
        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && this.GetType() == money.GetType();
        }
    }
}


using System;

namespace tdd.infrastructure
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}

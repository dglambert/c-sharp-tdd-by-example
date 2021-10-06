
using System;

namespace tdd.infrastructure
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money times(int multiplier)
        {
            return Money.dollar(amount * multiplier);
        }
    }
}

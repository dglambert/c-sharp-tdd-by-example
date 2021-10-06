using System;

namespace tdd.infrastructure
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money times(int multiplier)
        {
            return Money.franc(amount * multiplier);
        }
    }
}

using System;

namespace Shop
{
    public class MontageProgram : DigitalProduct
    {
        public MontageProgram(string name, string developer, string publisher, double price, DateTime realiseDate) : base(name, developer, publisher, price, realiseDate)
        {
            Type = ProductType.VideoMontage;
        }
    }
}

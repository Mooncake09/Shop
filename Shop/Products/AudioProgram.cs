using System;

namespace Shop
{
    public class AudioProgram : DigitalProduct
    {
        public AudioProgram(string name, string developer, string publisher, double price, DateTime realiseDate) : base(name, developer, publisher, price, realiseDate)
        {
            Type = ProductType.AudioProgram;
        }
    }
}

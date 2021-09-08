using System;

namespace Shop
{
    public class ModelingProgram : DigitalProduct
    {
        public ModelingProgram(string name, string developer, string publisher, double price, DateTime realiseDate) : base (name, developer, publisher, price, realiseDate)
        {
            Type = ProductType.ModelingProgram;
        }
    }
}

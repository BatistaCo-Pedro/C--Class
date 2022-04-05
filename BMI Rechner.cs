using System;

namespace C__Class
{
    public class BMIRechner : Cat
    {
        public BMIRechner(string name, int weight, double size) : base(name, weight, size)
        {
            Name = name;
            Weight = weight;
            Size = size;
        }
        
        public double BMI()
        {
            return Weight / (Size * Size);
        }
    }
}
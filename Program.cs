using System;
using System.Linq;

namespace C__Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Cat object
            Cat[] cat = new Cat[3];
            BMIRechner[] bmi = new BMIRechner[3];
            for (int i = 1; i < cat.Length + 1; i++)
            {
                cat[i - 1] = new Cat("Berti " + i.ToString(), 10, i * 5);
                bmi[i - 1] = new BMIRechner("Berti " + i.ToString(), 10, i * 5);
            }

            for (int i = 0; i < cat.Length; i++)
            {
                Console.WriteLine(cat[i].Name + "\t" + cat[i].Weight + "\t" + cat[i].Size + "\t" + bmi[i].BMI());
            }
        }

    }
}

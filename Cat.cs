namespace C__Class
{
    public class Cat
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }

        public Cat(string name, int weight, double size)
        {
            Name = name;
            Weight = weight;
            Size = size;
        }
    }
}
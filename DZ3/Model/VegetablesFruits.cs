namespace DZ3.Model
{
    public partial class VegetablesFruits
    {
        public VegetablesFruits() {          
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string TypeVF { get; set; }
        public string Color { get; set; }
        public int Colorie { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Name} - {TypeVF} - {Color} - {Colorie}";
        }
    }
}

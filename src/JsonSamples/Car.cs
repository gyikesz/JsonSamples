namespace JsonSamples
{
    public class Car : Entity
    {
        public Car()
        {
            Version = 1.0;
        }

        public string PlateNumber { get; set; }

        public Owner Owner { get; set; }
    }
}

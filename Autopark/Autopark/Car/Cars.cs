using System;

namespace Autopark.Car
{
    internal class Cars
    {
        List<Car> cars;
        public string Owner { get; }

        public Cars(string owner)
        {
            cars = new List<Car>();
            Owner = owner;
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Add(Car[] cars)
        {
            foreach (Car car in cars)
            {
                Add(car);
            }
        }

        public int Count => cars.Count;

        public Car this[int index]
        {
            get => cars[index];
            set => cars[index] = value;
        }
    }
}

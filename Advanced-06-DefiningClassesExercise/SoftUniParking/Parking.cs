namespace SoftUniParking
{
    using System.Collections.Generic;
    using System.Linq;

    public class Parking
    {
        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
        }

        private List<Car> cars;

        private int capacity;

        public int Count
        {
            get
            {
                return this.cars.Count();
            }
        }

        public string AddCar(Car car)
        {
            if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (this.capacity <= cars.Count)
            {
                return "Parking is full!";
            }
            else
            {
                this.cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                var car = cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
                this.cars.Remove(car);

                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return this.cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            for (int i = 0; i < registrationNumbers.Count; i++)
            {
                this.cars.RemoveAll(c => c.RegistrationNumber == registrationNumbers[i]);
            }
        }
    }
}
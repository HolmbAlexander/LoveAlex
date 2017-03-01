using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupparbeteADL.Models
{
    public static class DataManager
    {

        static List<Car> cars = new List<Car>
        {
            new Car { Id = 1, Brand = "Fiat", Doors = 4, TopSpeed = 150 },
            new Car { Id = 2, Brand = "Ford", Doors = 2, TopSpeed = 270 },
            new Car { Id = 3, Brand = "Chevrolet", Doors = 6, TopSpeed = 180 }
        };

        public static void AddCar(CarsCreateVM viewModel)
        {
            Car car = new Car
            {
                Brand = viewModel.Brand,
                Doors = viewModel.Doors,
                TopSpeed = viewModel.TopSpeed,
                Id = cars.Max(o => o.Id) + 1
            };

            cars.Add(car);
        }

        public static CarsIndexVM[] ListCars()
        {
            return cars.Select(c => new CarsIndexVM
            {
                Brand = c.Brand,
                ShowAsFast = c.TopSpeed >= 250
            }).ToArray();
        }

    }
}

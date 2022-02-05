using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Helicopter.Models
{
    public class AirVehicleModel
    {
        public int Id { get; set; }

        [Description]
        public string Name { get; set; }

        [Description]
        public int Price { get; set; }

        [Description]
        public string Description { get; set; }

        [Description]
        public int MaxHorizontalSpeed { get; set; }

        [Description]
        public int MaxVerticalSpeed { get; set; }

        [Description]
        public bool HasItCamera { get; set; }

        [Description]
        public int WorkingHours { get; set; }

        [Description]
        public int QuantityOfMotors { get; set; }

        [Description]
        public int QuantityOfPropellers { get; set; }

        [Description]
        public string FirstPhoto { get; set; }

        [Description]
        public string SecondPhoto { get; set; }

        [Description]
        public string ThirdPhoto { get; set; }

        [Description]
        public string FourthPhoto { get; set; }

    }
}/*Vehicles.Add(new AirVehicleModel
                {
                    Name = "Phantom 4 RTK",
                    Price = 574800,
                    HasItCamera = true,
                    MaxHorizontalSpeed = 16,
                    MaxVerticalSpeed = 6,
                    QuantityOfMotors = 4,
                    QuantityOfPropellers = 4,
                    WorkingHours = 30,
                    Description = "Уникальная новая модель дрона из серии DJI Phantom 4, оснащенная модулем RTK, для выполнения геодезических, картографических и инспекционных задач. Обеспечивает высокую точность и производительность."
                });*/

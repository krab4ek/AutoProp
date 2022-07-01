﻿namespace AutoProp
{
    internal class Garage
    {
        public int NumberOfCars { get; set; } = 1;
        public Car MyAuto { get; set; } = new Car();

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}

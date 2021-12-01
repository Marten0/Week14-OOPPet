using System;

namespace OOPCar
{
    class Program

    {
        class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odo;
            int fueltank;
            public Car(string _mark, string _model, string _regNumber, string _color)
            {
                mark = _mark;
                model = _model;
                regNumber = _regNumber;
                color = _color;
                odo = 0;
                fueltank = 60;
                Console.WriteLine($"{mark} {model} {regNumber} has been created. ");
            }
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic", "12345", "Black");
        }
    }
}

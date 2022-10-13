using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    interface IMovable
    {
    // константа
    const int minSpeed = 0;     // минимальная скорость
    // статическая переменная
    static int maxSpeed = 60;   // максимальная скорость
    // метод
    //void Move();                // движение
    // свойство
    string Name { get; set; }   // название

    delegate void MoveHandler(string message);  // определение делегата для события
    // событие
    event MoveHandler MoveEvent;    // событие движения

    // реализация метода по умолчанию
    void Move() => Console.WriteLine("Walking");
    // реализация свойства по умолчанию
    // свойство только для чтения
    static double GetTime(double distance, double speed) => distance / speed;
    static int MaxSpeed
    {
        get => maxSpeed;
        set
        {
            if (value > 0) maxSpeed = value;
        }
    }
}

Console.WriteLine(IMovable.minSpeed);   // 0
Console.WriteLine(IMovable.MaxSpeed);   // 60
IMovable.MaxSpeed = 65;
Console.WriteLine(IMovable.MaxSpeed);   // 65
double time = IMovable.GetTime(500, 10);
Console.WriteLine(time);    // 50

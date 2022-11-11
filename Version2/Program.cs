Console.WriteLine("Введите дистанцию (больше 10)");
int distance = Convert.ToInt32(Console.ReadLine());          //Преобразовываем строчный тип в число и записываем в переменную
Console.WriteLine("Введите ОТ какого друга побежит собака (1 или 2) ");
int friend  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость первого друга");
int speed1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость второго друга");
int speed2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость собаки");
int dogspeed = Convert.ToInt32(Console.ReadLine());
int time;
int count = 0;

Console.WriteLine("==Исходные данные==:");
Console.WriteLine($"Дистанция = {distance}");
Console.WriteLine($"Скорость первого друга = {speed1}, скорость второго друга = {speed2}");
Console.WriteLine($"Скорость собаки = {dogspeed}, пес бежит от {friend} - го друга");

while (distance>10)
{
    if (friend == 2)
    {
    time = distance/(speed1 + dogspeed);
    distance = distance - (speed1+speed2) * time; 
    friend = 1;
    }
    else
    {
    time = distance/(speed2 + dogspeed);
    distance = distance - (speed1+speed2) * time;
    friend = 2;
    }
    count++;
    
}
Console.WriteLine("-----------------------------");
Console.WriteLine($"Собака пробежит {count} раз(а)");
Console.WriteLine("-----------------------------"); 
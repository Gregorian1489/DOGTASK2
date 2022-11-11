Console.WriteLine("Введите дистанцию (больше 10)");
double distance = Convert.ToDouble(Console.ReadLine());          //Преобразовываем строчный тип в число и записываем в переменную
Console.WriteLine("Введите ОТ какого друга побежит собака (1 или 2) ");
int friend  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость первого друга");
double speed1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите скорость второго друга");
double speed2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите скорость собаки");
double dogspeed = Convert.ToDouble(Console.ReadLine());
double time;
int count = 0;

Console.WriteLine("==Исходные данные==:");
Console.WriteLine($"Дистанция = {distance}");
Console.WriteLine($"Скорость первого друга = {speed1}, скорость второго друга = {speed2}");
Console.WriteLine($"Скорость собаки = {dogspeed}, пес бежит от {friend} - го друга");

while (distance>10)
{
    if (friend == 2) // Вернул свой вариант, чтобы не запутаться
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
    distance = distance - (speed1+speed2) * time; // изменения принимаются)
    count++;
    distance = distance - (speed1+speed2) * time; 
    
}
Console.WriteLine("-----------------------------");
Console.WriteLine($"Собака пробежит {count} раз(а)");
Console.WriteLine("-----------------------------"); 

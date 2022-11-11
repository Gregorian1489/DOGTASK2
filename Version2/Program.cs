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
    if (friend == 1) // Судя по блок-схеме из лекции, здесь должно быть friend == 1
    {
    time = distance/(speed1 + dogspeed);
    friend = 2; // а здесь, соответственно friend = 2;
    }
    else
    {
    time = distance/(speed2 + dogspeed);
    friend = 1; // здесьполучается friend = 1;
    }
    distance = distance - (speed1+speed2) * time; // для экономии строк эту формулу можно один раз записать. Надеюсь, я не ошибаюсь))
    count++;
    
}
Console.WriteLine("-----------------------------");
Console.WriteLine($"Собака пробежит {count} раз(а)");
Console.WriteLine("-----------------------------"); 

void Zadacha1()
{
//Написать программу, которая определит, является ли треугольник 
// со сторонами a, b, c равнобедренным

Random rand = new Random();
int sideA = rand.Next(30, 60);
int sideB = rand.Next(60, 90);
int sideC = rand.Next(30, 40);
 if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
 {
    if(sideA == sideB || sideB == sideC || sideA == sideC)
    Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} равнобедренный");
    else
        Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} неравнобедренный");
    
 }
    else
        Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} не существует");
}


void Zadacha2()
{
//На вход подаются год, номер, месяца и день рождения человека
// определить возраст человека на момент 01 июля 2022 года

Random rand = new Random();
int day = rand.Next(1, 31);
int month = rand.Next(1, 12);
int year = rand.Next(1990, 2022);
int age = 2022 - year;
Console.WriteLine ($"Человек родился: {day}.{month}.{year}");
if (month > 7 || (month == 7 && day > 1))
{
    age --;
}
Console.WriteLine("Возраст человека: " + age);
}


void Zadacha3()
{
//Иван в начале года открыл счет в банке, положив 1000руб Через каждый месяц
// размер вклада увеличивается на 1,5% от имеющейся суммы. Определеить размер 
// депозита через n месяцев
Random rand = new Random();
double deposit = 1000;
int month = rand.Next(1, 1000);
for (int i = 0; i < month; i++)
{
    deposit *= 1.015;
}
Console.WriteLine($"Сумма депозита через {month} месяцев (-ев) составляет {Math.Round(deposit,2)} рублей ");

}

void Zadacha4()
{
//Дано натуральное число, в котором все цифры различны. Определить, какая цифра 
// расположена в нем левее: максимальная или минимальная
//697284105

int number = 697284105;
int max = -1;
int min = 10;
int positionMax = 0;
int positionMin = 0;
int count = 1;
Console.Write($"В числе {number} ");

while(number > 0);
{
    int digit = number % 10;
    if (digit > max) 
    {
        max = digit;
        positionMax = count;
    }
    else if (digit < min) 
    {
        min = digit;
        positionMin = count;
    }
    count++;
    number /= 10;
}
if (positionMax > positionMin)
{
    Console.WriteLine($"Цифра {max} стоит левее цифры {min}");
}
else
{
    Console.WriteLine($"Цифра {min} стоит левее цифры {max}");
}

}



//Zadacha1();
//Zadacha2();
//Zadacha3();
Zadacha4();

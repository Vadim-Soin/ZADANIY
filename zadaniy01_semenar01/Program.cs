Console.WriteLine("Введите число");
int numbers1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int numbers2 = Convert.ToInt32(Console.ReadLine());
if (numbers1 > numbers2)
    Console.WriteLine(" Первое число больше "+numbers1);
if (numbers2 > numbers1)    
    Console.WriteLine(" Второе число больше "+numbers2);
if (numbers1 == numbers2)
    Console.WriteLine(" Числа равны " +numbers1, numbers2);

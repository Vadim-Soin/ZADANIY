Console.WriteLine("Введите число");
int numbers = Convert.ToInt32 (Console.ReadLine ());
int i = 1;
while ( i <= numbers )
{
    if (i % 2 == 0) Console.Write (i + " ");
    i++;
}
Console.WriteLine("");

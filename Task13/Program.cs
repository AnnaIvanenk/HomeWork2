int value = 645;

if (value < 100) Console.WriteLine("Третьей цифры нет");
else 
{
    int c = value % 10;
    Console.WriteLine(c);
}


int value2 = 78;

if (value2 < 100) Console.WriteLine("Третьей цифры нет");
else 
{
    int c2 = value2 % 10;
    Console.WriteLine(c2);
}


int value3 = 32679;

if (value3 < 100) Console.WriteLine("Третьей цифры нет");
else 
{
    int c3 = (value3 % 1000);
    int c33 = c3 / 100;
    Console.WriteLine(c33);
}
int numberA = new Random().Next(1, 10); // 1 2 3 4 5 .... 9 [min, max-1]
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int numberC = new Random().Next(1, 10);
Console.WriteLine(numberC);
int result = numberA + numberB + numberC;
Console.WriteLine(result);

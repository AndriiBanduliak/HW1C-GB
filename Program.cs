Console.Write("Enter the number one ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter the number two ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter the number three ");
int num3 = int.Parse(Console.ReadLine());

if(num1 > num2 && num1 >num3)
Console.WriteLine($" The biggest number is {num1} ");
if(num2>num1 && num2>num3)
Console.WriteLine($"The biggest number is {num2} ");
else
Console.Write($"The biggest number is {num3}");

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int maxnumber = number1;
if (number2 > maxnumber)
{
  maxnumber = number2;
  System.Console.WriteLine("Максимальное число: " + maxnumber);  
}
else
{
   maxnumber = number1; 
System.Console.WriteLine("Максимальное число: " + maxnumber);
}
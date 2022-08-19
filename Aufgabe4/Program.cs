Console.Write("Введите первое число "); 
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число "); 
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число "); 
int number3 = Convert.ToInt32(Console.ReadLine());
int maxnumber = number1;
if (number2 > maxnumber && number2 > number3)
{
  maxnumber = number2;
  System.Console.WriteLine("Максимальное число: " + maxnumber);  
}
else if (number3 > maxnumber && number3 > number1)
{
   maxnumber = number3;
  System.Console.WriteLine("Максимальное число: " + maxnumber); 
}
else
{
   maxnumber = number1; 
System.Console.WriteLine("Максимальное число: " + maxnumber);
}
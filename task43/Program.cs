// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double k1 = Input1("k1");
double b1 = Input1("b1"); 
double k2 = Input2("k2"); 
double b2 = Input2("b2"); 
if (k1 == k2) 
{
    Console.WriteLine("Прямые параллельны"); 
}
else // иначе
{
     double x = ResultX(b2,b1,k1,k2);    
     double y = ResultY(b2,b1,k1,k2); 
     Console.WriteLine($"Координаты пересечения прямых ({x};{y})"); 
}

double ResultX(double a2,double a1, double b1,double b2) 
{
    return (a2-a1)/(b1-b2);
}
double ResultY(double a2,double a1, double b1,double b2) 
{
    return b2*((a2-a1)/(b1-b2)) +a2;
}
double Input1(string k1) 
{
    Console.Write($"Введите коэффициенты для функции первой прямой {k1} ");
    return Convert.ToDouble(Console.ReadLine());   
}
double Input2(string k2) 
{
    Console.Write($"Введите коэффициенты для функции второй прямой {k2} ");
    return Convert.ToDouble(Console.ReadLine()); 
}

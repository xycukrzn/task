Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int с = int.Parse(Console.ReadLine());
if (a > b && a > c ) {
    Console.WriteLine("Первое число самое большое");
}
if (a > b && a < c ) {
    Console.WriteLine("Второе число самое большое");
}
if  (a < b && a < c ) {
    Console.WriteLine("Третье число самое большое");
}
else {
    Console.WriteLine("Хм");
}
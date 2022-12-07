// task 25

Console.Clear();
int a = ReadInt("Введите число A: ");
int b = ReadInt("Введите число B: ");
ToDegree(a, b);
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
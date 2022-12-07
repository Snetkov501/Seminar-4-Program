// task 29

Console.Clear();
void setValue(int[] mas, int n)
 {
     Console.WriteLine("Введите число: " + n);
     mas[n] = Convert.ToInt32(Console.ReadLine());
 }
 int[] mas = new int[9];
 for (int n = 0; n < mas.Length; n++) 
    {
     setValue(mas, n);
    }
 string output = $"{mas[0]}";
 for (int n = 1; n < mas.Length - 1; n++)
  {
     output += $", {mas[n]}";
  }
 output += $", {mas[8]}]";
 Console.WriteLine("Дружище, теперь это твой МАССИВ:[" + output);
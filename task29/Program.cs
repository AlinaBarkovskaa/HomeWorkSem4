Console.Clear();
int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
 Console.Write("Введите число: ");
 int a = Convert.ToInt32(Console.ReadLine());
 array[i] = a;
}
Console.WriteLine($"[{string.Join(", ", array)}]");

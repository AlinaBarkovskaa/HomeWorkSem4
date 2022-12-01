Console.Clear();
int n = 8;
int[] array = new int[n];
for(int i = 0; i < array.Length; i++)
{
 Console.Write("Введите число: ");
 int a = Convert.ToInt32(Console.ReadLine());
 array[i] = a;
}
Console.WriteLine($"[{string.Join(", ", array)}]");

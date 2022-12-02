Console.Clear();
Console.Write("Введите количество элементов массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите элемент массива: ");
    int a = Convert.ToInt32(Console.ReadLine());
    array[i] = a;
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write("Введите число на которое будет сдвигаться массив:  ");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 0)
{
    m = -m;
    m = m % array.Length;
}
else
{
    m = m % array.Length;
    m = array.Length - m;
}
for (int i = m; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
for (int i = 0; i < m; i++)
{
    Console.WriteLine(array[i]);
}

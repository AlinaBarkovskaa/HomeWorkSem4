Console.Clear();
Console.WriteLine("введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int rezult = a;
for(int i = 1; i < b; i++)
{
  rezult = rezult *a;
}
Console.Write($"А в спени B = {rezult}");

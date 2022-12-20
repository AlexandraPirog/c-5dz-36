//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
Arraywithrandomnumbers(arr);
int sum= 0;
for (int k = 0; k < arr.Length; k+=2)
{
    sum += arr[k];
}

void Arraywithrandomnumbers(int[] arr)
{
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-99,100);

}
}
System.Console.WriteLine("Наш массив: [" + string.Join(", ", arr) + "]");
System.Console.WriteLine($"Сумма чисел на нечетных позициях {sum}");

/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] arry(int size){
    int[] arr = new int[size];
    for(int i=0; i<size; i++) arr[i]=new Random().Next(100, 1000);
    return arr;
}
int sum(int [] arr){ int S=0;
    for(int i=1; i<arr.Length; i=i+2) S=S+arr[i];
    return S; 
}


Console.Clear();
Console.WriteLine("Введите разрядность массива");
int size = int.Parse(Console.ReadLine());
int [] mass=arry(size);
Console.WriteLine($"[ {string.Join(" ", mass)} ]");
Console.WriteLine("сумма элементов на нечётных позициях: " + sum(mass));
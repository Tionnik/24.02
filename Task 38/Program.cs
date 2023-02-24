/* Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] arry(int size){
    int[] arr = new int[size];
    for(int i=0; i<size; i++) arr[i]=new Random().Next(0, 100);
    return arr;
}
int res(int [] arr){ int Max =arr[1]; int Min = arr[1];
    for(int i=1; i<arr.Length; i++){
        if (arr[i]>Max) Max=arr[i];
        if (arr[i]<Min) Min=arr[i];
    } 
return (Max-Min); 
}

Console.Clear();
Console.WriteLine("Введите разрядность массива");
int size = int.Parse(Console.ReadLine());
int [] mass=arry(size);
Console.WriteLine($"[ {string.Join(" ", mass)} ]");
Console.WriteLine("разницу между максимальным и минимальным элементов массива: " + res(mass));
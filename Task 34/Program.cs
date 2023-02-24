int[] arry(int size){
    int[] arr = new int[size];
    for(int i=0; i<size; i++) arr[i]=new Random().Next(100, 1000);
    return arr;
}

int namber(int [] mass){
int N=0;
    for (int i=0; i<mass.Length;i++) if (mass[i]%2==0) N++;
return N;
}

Console.Clear();
Console.WriteLine("Введите разрядность массива");
int size = int.Parse(Console.ReadLine());
int [] mass=arry(size);
Console.WriteLine($"[ {string.Join(" ", mass)} ]");
Console.WriteLine(namber(mass));
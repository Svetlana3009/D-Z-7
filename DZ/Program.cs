// Console.Clear();
// void FromMtoN(int m, int n)
// {
// if (m > n)
// {
// FromMtoN(m - 1, n);
// System.Console.Write(m + " ");
// }
// else if (n > m)
// {
// FromMtoN(m, n - 1);
// System.Console.Write(n + " ");
// }
// else System.Console.Write(m + " ");
// }
// FromMtoN(15, 5);


// Console.Clear();
// Console.Write("Введите неотрицательное число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите неотрицательное число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int recAkkerman(int m, int n)
// {
//     if (m == 0) 
//     return n + 1;
//     else 
//         if (n == 0) 
//         return recAkkerman(m - 1, 1);
//         else 
//         return recAkkerman(m - 1, recAkkerman(m, n - 1));
// }
// Console.Write($" {recAkkerman(m, n)} ");


Console.Clear();
int[] array={1, 2, 5, 0, 10, 34};
Console.WriteLine(string.Join(", ", array));

void Print(int[] array, int i = 0)
{
    if(i != array.Length) 
    {
        Print(array, i + 1);
        Console.Write($"{array[i]}, ");
    }
}
    
Print(array);


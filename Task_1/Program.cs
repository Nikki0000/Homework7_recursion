// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.



void Func (int m, int n) {
    int temp;
    if (m <= 0 || n <= 0) {
        Console.WriteLine("Натуральное число должно быть положительным");
    } else if (n >= m) {
        Console.Write(m + " ");
        if (n > m) {
            Func(m + 1, n);
        }
    } else if (m > n) {
        temp = m;
        m = n;
        n = temp;
        Console.Write(m + " ");
        if (n > m) {
            Func(m + 1, n);
        }
    }
}

Func(1, 5);
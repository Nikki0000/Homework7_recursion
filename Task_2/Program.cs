// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int Func (int m, int n) {
    int res = 0;
    if (m == 0) {
        res = n + 1;
    }
    else if (n == 0) {
        res = Func(m - 1, 1);
    }
    else {
        res = Func(m - 1, Func(m, n - 1));
    }

    return res;
}

int res = Func(3, 2);
Console.WriteLine(res);
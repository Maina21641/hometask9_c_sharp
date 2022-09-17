//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// Пример из Wiki
// A(m, n)={
// n+1 это m=0
// A(m-1, 1) это m>0, n=0
// A(m-1, A(m, n-1)) это m>0, n>0}

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return A(m - 1, 1);
    }
    else //m>0, n>0
    {
        return A(m - 1, A(m, n - 1));
    }
}

Console.WriteLine(A(2, 3));//9

// Console.WriteLine(A(2, 2));//7
// Console.WriteLine(A(2, 1));//5
// Console.WriteLine(A(2, 0));//3

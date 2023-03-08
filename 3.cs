using System;
class Program {

    private static int Sum(int[] a) {
        int ans = 0;
        foreach (int x in a)
            ans += x;
        return ans;
    }

    private static int Average(int[] a) {
        return (Sum(a) / a.Length);
    }

    private static int SumOfEven(int[] a) {
        int ans = 0;
        foreach (int x in a) {
            if (x % 2 == 0)
                ans += x;
        }
        return ans;
    }

    private static int SumOfOdd(int[] a) {
        return (Sum(a) - SumOfEven(a));
    }
    private static int SumOfPossitive(int[] a) {
        int ans = 0;
        foreach (int x in a) {
            if (x > 0)
                ans += x;
        }
        return ans;
    }

    private static int SumOfNegative(int[] a) {
        return (Sum(a) - SumOfPossitive(a));
    }

    private static int iMin(int[] a) {
        int mi = int.MaxValue, ans = -1;
        for (int i = 0; i < a.Length; i++) {
            if (a[i] < mi) {
                mi = a[i];
                ans = i;
            } 
        }
        return ans;
    }
    private static int iMax(int[] a) {
        int ma = int.MinValue, ans = -1;
        for (int i = 0; i < a.Length; i++) {
            if (a[i] > ma) {
                ma = a[i];
                ans = i;
            }
        }
        return ans;
    }

    private static int SumBetween(int[] a) {
        int ans = 0;
        for (int i = Math.Min(iMax(a), iMin(a)) + 1; i < Math.Max(iMax(a), iMin(a)); i++)
            ans += a[i];
        return ans;
    } 
    static void Main() {

        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        var input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(input[i]);

        Console.WriteLine("Testing Sum: {0}", Sum(a));
        Console.WriteLine("Testing SumOfEven: {0}", SumOfEven(a));
        Console.WriteLine("Testing SumOfOdd: {0}", SumOfOdd(a));
        Console.WriteLine("Testing SumOfPossitive: {0}", SumOfPossitive(a));
        Console.WriteLine("Testing SumOfNegative: {0}", SumOfNegative(a));
        Console.WriteLine("Testing iMin: {0}", iMin(a));
        Console.WriteLine("Testing iMax: {0}", iMax(a));
        Console.WriteLine("Testing SumBetween: {0}", SumBetween(a));

    }
}
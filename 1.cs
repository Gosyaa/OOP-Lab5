using System;
class Program {
    static void Main() {

        int n = int.Parse(Console.ReadLine());  
        int[] myArray = new int[n];
        int ans = 0;
        for (int i = 0; i < n; i++) {
            Console.Write("a[{0}] = ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        foreach (int x in myArray)
            Console.Write("{0} ", x);
    }
}
using System.Globalization;

public class Program
{
    public static void Main()
    {
        int[/*linha*/,/*coluna*/] n = new int[3, 5];
        /*
            10 20 30 40 50
            60 70 80 90 15
            25 35 45 55 65
        */

        n[0, 0] = 10; n[0, 1] = 20; n[0, 2] = 30; n[0, 3] = 40; n[0, 4] = 50;
        n[1, 0] = 60; n[1, 1] = 70; n[1, 2] = 80; n[1, 3] = 90; n[1, 4] = 15;
        n[2, 0] = 25; n[2, 1] = 35; n[2, 2] = 45; n[2, 3] = 55; n[2, 4] = 65;

        Console.WriteLine(n[0, 4]);

        int[,] num = new int[5, 5] {
            { 30, 50, 50, 60, 70},
            { 40, 40, 60, 60, 80},
            { 70, 12, 60, 30, 76},
            { 90, 56, 32, 88, 67},
            { 90, 31, 42, 45, 6}
        };
        Console.WriteLine(num[3,3]);
    }   
}
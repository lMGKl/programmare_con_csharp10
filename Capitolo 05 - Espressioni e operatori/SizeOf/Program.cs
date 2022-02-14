﻿/* Programmare con C# 10 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 5: operatore sizeof
 */


public struct Point
{
    public Point(byte tag, double x, double y) => (Tag, X, Y) = (tag, x, y);

    public byte Tag { get; }
    public double X { get; }
    public double Y { get; }
}

public class MiaClasse
{
    public string nome;

    public DateTime data;
}

public class SizeOfOperator
{
    public static void Main()
    {
        Console.WriteLine($"sizeof(byte) = {sizeof(byte)}");  // output: 1
        Console.WriteLine($"sizeof(double) = {sizeof(double)}");  // output: 8

        DisplaySizeOf<Point>();  // output: Size of Point is 24
        DisplaySizeOf<decimal>();  // output: Size of System.Decimal is 16


        unsafe
        {
            Console.WriteLine($"sizeof(Point*) = {sizeof(Point*)}");  // output: 8
        }
    }

    static unsafe void DisplaySizeOf<T>() where T: unmanaged
    {
        Console.WriteLine($"Size of {typeof(T)} is {sizeof(T)}");
    }
}
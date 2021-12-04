using System;

namespace REC_85
{

    class Program
    {
        static void TrianglePrint(int CathetLength)
        {
            char Border = '*';
            for (int i = 0; i < CathetLength; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i != CathetLength - 1)
                        Console.Write(j == 0 || j == i ? Border : ' ');
                    else
                        break;
                }
                Console.WriteLine(i == CathetLength - 1 ? new string(Border, CathetLength) : "");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину катета: ");
            int CathetLength = int.Parse(Console.ReadLine());
            TrianglePrint(CathetLength);
            Console.ReadKey();
        }
    }
}

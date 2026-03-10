using System;

namespace BukleAkats
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] balioak = { 10, 20, 30, 40, 50 };
            int batura = 0;

            for (int i = 0; i < balioak.Length; i++)
            {
                batura += balioak[i];
            }

            int batazBestekoa = batura / balioak.Length;
            Console.WriteLine($"2. Batez bestekoa: {batazBestekoa}");

            int kontagailua = 0;

            while (kontagailua < 5)
            {
                Console.WriteLine($"4. Kontagailua: {kontagailua}");
                kontagailua++;
            }

            int[] arrayZenbakiak = { 1, 2, 3, 4, 5 };

            Console.WriteLine("5. Zenbakien karratuak:");

            foreach (int zenbakia in arrayZenbakiak)
            {
                int karratua = zenbakia * zenbakia;
                Console.WriteLine($"Zenbakiaren karratua: {karratua}");
            }

            int[] balioMistoa = { 1, 3, 5, 7, 9 };
            int emaitza = 0;

            for (int i = 0; i < balioMistoa.Length; i++)
            {
                emaitza += balioMistoa[i];
            }

            Console.WriteLine($"7. Zenbakien batura: {emaitza}");
        }
    }
}

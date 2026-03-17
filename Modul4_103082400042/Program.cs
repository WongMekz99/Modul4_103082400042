using System;
using Modul4_103082400042;

namespace Modul4_103082400042
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- TUGAS 1: TABLE-DRIVEN ---
            KodeBuah cariBuah = new KodeBuah();
            Console.WriteLine("=== TES KODE BUAH ===");
            Console.WriteLine("Apel: " + cariBuah.getKodeBuah("Apel"));
            Console.WriteLine("Kurma: " + cariBuah.getKodeBuah("Kurma"));

            Console.WriteLine("\n=== SIMULASI KARAKTER (Tekan W, S, atau X) ===");
            Console.WriteLine("Tekan ESC untuk berhenti simulasi.\n");

            PosisiKarakterGame hero = new PosisiKarakterGame();

            // Loop ini bikin program nunggu input keyboard kamu
            while (true)
            {
                // Baca tombol yang ditekan tanpa perlu enter
                ConsoleKeyInfo input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.Escape) break; // Berhenti kalau tekan ESC

                if (input.Key == ConsoleKey.W)
                {
                    hero.AktifkanTombol("TombolW");
                }
                else if (input.Key == ConsoleKey.S)
                {
                    hero.AktifkanTombol("TombolS");
                }
                else if (input.Key == ConsoleKey.X)
                {
                    hero.AktifkanTombol("TombolX");
                }
            }
        }
    }
}
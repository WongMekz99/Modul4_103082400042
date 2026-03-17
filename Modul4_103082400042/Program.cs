using System;
using Modul4_103082400042; 

namespace Modul4_103082400042
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- TES TABLE-DRIVEN (KODE BUAH) ---
            KodeBuah cariBuah = new KodeBuah();
            Console.WriteLine("=== Output Table-Driven ===")
            Console.WriteLine("Kode Buah Apel: " + cariBuah.getKodeBuah("Apel"));
            Console.WriteLine("Kode Buah Kurma: " + cariBuah.getKodeBuah("Kurma"));
            Console.WriteLine();

            // --- TES STATE-BASED (POSISI KARAKTER) ---
            Console.WriteLine("=== Output State-Based ===");
            PosisiKarakterGame hero = new PosisiKarakterGame();

            // Perubahan: Berdiri -> Terbang
            hero.AktifkanTombol("TombolW");

            // Perubahan: Terbang -> Berdiri
            hero.AktifkanTombol("TombolS");

            // Perubahan: Berdiri -> Jongkok
            hero.AktifkanTombol("TombolS");

            // Perubahan: Jongkok -> Tengkurap
            hero.AktifkanTombol("TombolS");

            Console.WriteLine("\nProgram Selesai. Tekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}
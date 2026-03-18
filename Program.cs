using System;
using TugasJurnal_modul4_103082400002;

namespace TugasJurnal_modul_103082400002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO TABLE-DRIVEN (KodeBuah) ===");

            // Menampilkan semua daftar buah
            KodeBuah.TampilkanSemuaBuah();

            Console.WriteLine("\n=== CONTOH PENGGUNAAN ===");

            // Array contoh buah yang akan dicek
            string[] contohBuah = { "Apel", "Durian", "Mangga", "Semangka", "Anggur" };

            foreach (string buah in contohBuah)
            {
                string kode = KodeBuah.getKodeBuah(buah);
                Console.WriteLine($"Buah: {buah} -> Kode: {kode}");
            }

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}

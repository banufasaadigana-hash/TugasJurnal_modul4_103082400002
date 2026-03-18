using System;
using TugasJurnal_modul4_103082400002;

namespace TugasJurnal_modul_103082400002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("JURNAL MODUL 4 - NIM: 103082400002");
            Console.WriteLine("=========================================\n");
            Console.WriteLine("=== TABLE-DRIVEN (KodeBuah) ===\n");
            
            // Tampilkan semua daftar buah
            KodeBuah.TampilkanSemuaBuah();
            Console.WriteLine();
            
            // Contoh pengambilan beberapa kode buah
            string[] contohBuah = { "Apel", "Durian", "Mangga", "Semangka", "Anggur" };

            Console.WriteLine("Pengambilan Kode Buah:");
            Console.WriteLine("-----------------------");
            foreach (string buah in contohBuah)
            {
                string kode = KodeBuah.getKodeBuah(buah);
                Console.WriteLine($"Buah {buah,-10} : {kode}");
            }
            
            Console.WriteLine("\nTekan Enter untuk lanjut ke State-Based...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("=== STATE-BASED CONSTRUCTION ===");
            Console.WriteLine("NIM: 103082400002 => NIM % 3 = 2");
            Console.WriteLine("Output spesial:");
            Console.WriteLine("- Terbang -> Jongkok : \"posisi landing\"");
            Console.WriteLine("- Berdiri -> Terbang : \"posisi take off\"");
            Console.WriteLine("=====================================\n");

            // Buat objek game
            PosisiKarakterGame game = new PosisiKarakterGame();
            Console.WriteLine();

            // Simulasi 1: Berdiri -> Terbang (harusnya muncul "posisi take off")
            Console.WriteLine("Simulasi 1: Tekan Tombol W (Berdiri -> Terbang)");
            game.TekanTombolW();  // Berdiri -> Terbang (harus ada output "posisi take off")
            Console.WriteLine();

            // Simulasi 2: Terbang -> Jongkok (harusnya muncul "posisi landing")
            Console.WriteLine("Simulasi 2: Tekan Tombol S (Terbang -> Jongkok)");
            game.TekanTombolS();  // Terbang -> Jongkok (harus ada output "posisi landing")
            Console.WriteLine();

            // Simulasi 3: Jongkok -> Berdiri
            Console.WriteLine("Simulasi 3: Tekan Tombol W (Jongkok -> Berdiri)");
            game.TekanTombolW();  // Jongkok -> Berdiri
            Console.WriteLine();

            // Simulasi 4: Berdiri -> Jongkok
            Console.WriteLine("Simulasi 4: Tekan Tombol S (Berdiri -> Jongkok)");
            game.TekanTombolS();  // Berdiri -> Jongkok
            Console.WriteLine();

            // Simulasi 5: Jongkok -> Tengkurap
            Console.WriteLine("Simulasi 5: Tekan Tombol S (Jongkok -> Tengkurap)");
            game.TekanTombolS();  // Jongkok -> Tengkurap
            Console.WriteLine();

            // Simulasi 6: Tengkurap -> Jongkok
            Console.WriteLine("Simulasi 6: Tekan Tombol W (Tengkurap -> Jongkok)");
            game.TekanTombolW();  // Tengkurap -> Jongkok
            Console.WriteLine();

            // Simulasi 7: Jongkok -> Berdiri
            Console.WriteLine("Simulasi 7: Tekan Tombol W (Jongkok -> Berdiri)");
            game.TekanTombolW();  // Jongkok -> Berdiri
            Console.WriteLine();

            // Simulasi 8: Berdiri -> Jongkok -> Tengkurap
            Console.WriteLine("Simulasi 8: Berdiri -> Jongkok -> Tengkurap");
            game.TekanTombolS();  // Berdiri -> Jongkok
            game.TekanTombolS();  // Jongkok -> Tengkurap
            Console.WriteLine();

            // Simulasi 9: Tengkurap -> Jongkok -> Berdiri -> Terbang
            Console.WriteLine("Simulasi 9: Tengkurap -> Jongkok -> Berdiri -> Terbang");
            game.TekanTombolW();  // Tengkurap -> Jongkok
            game.TekanTombolW();  // Jongkok -> Berdiri
            game.TekanTombolW();  // Berdiri -> Terbang (harus ada output "posisi take off")
            Console.WriteLine();

            // Simulasi 10: Terbang -> Jongkok (landing)
            Console.WriteLine("Simulasi 10: Tekan Tombol S (Terbang -> Jongkok)");
            game.TekanTombolS();  // Terbang -> Jongkok (harus ada output "posisi landing")
            Console.WriteLine();

            Console.WriteLine("\nSimulasi selesai!");
            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}

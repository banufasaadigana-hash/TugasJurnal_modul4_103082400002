using System;
using System.Collections.Generic;
using System.Text;

namespace TugasJurnal_modul4_103082400002
{
    internal class KodeBuah
    {
        private static Dictionary<string, string> kodeBuahTable = new Dictionary<string, string>()
        {
            {"Apel", "A00"},
            {"Aprikot", "B00"},
            {"Alpukat", "C00"},
            {"Pisang", "D00"},
            {"Paprika", "E00"},
            {"Blackberry", "F00"},
            {"Ceri", "H00"},
            {"Kelapa", "I00"},
            {"Jagung", "J00"},
            {"Kurma", "K00"},
            {"Durian", "L00"},
            {"Anggur", "M00"},
            {"Melon", "N00"},
            {"Semangka", "O00"}
        };

        // Method untuk mendapatkan kode buah berdasarkan nama buah
        public static string getKodeBuah(string namaBuah)
        {
            // Cek apakah buah ada dalam tabel
            if (kodeBuahTable.ContainsKey(namaBuah))
            {
                return kodeBuahTable[namaBuah];
            }
            else
            {
                return "Kode tidak ditemukan";
            }
        }

        // Method untuk menampilkan semua buah dan kodenya (opsional)
        public static void TampilkanSemuaBuah()
        {
            Console.WriteLine("=== DAFTAR BUAH DAN KODE ===");
            foreach (var item in kodeBuahTable)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("==============================");
        }
    }
}

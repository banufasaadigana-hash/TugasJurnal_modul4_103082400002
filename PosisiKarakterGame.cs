using System;
using System.Collections.Generic;
using System.Text;

namespace TugasJurnal_modul4_103082400002
{
    internal class PosisiKarakterGame
    {
        // Enum untuk state karakter
        public enum State
        {
            Berdiri,
            Jongkok,
            Tengkurap,
            Terbang
        }

        private State currentState;

        // Constructor - state awal: Berdiri (sesuai soal)
        public PosisiKarakterGame()
        {
            currentState = State.Berdiri;
            Console.WriteLine("State awal: Berdiri");
        }

        // Method untuk simulasi tombol ditekan
        public void TekanTombolS()
        {
            Console.WriteLine("tombol arah bawah ditekan"); // Output untuk NIM % 3 == 2? 
                                                            // Untuk NIM % 3 == 2, output ini diminta? 
                                                            // Soal mengatakan untuk NIM % 3 == 0 yang ada output "tombol arah bawah ditekan"
                                                            // Tapi kita bisa tetap menampilkan untuk debugging

            switch (currentState)
            {
                case State.Berdiri:
                    currentState = State.Jongkok;
                    break;
                case State.Jongkok:
                    currentState = State.Tengkurap;
                    break;
                case State.Tengkurap:
                    // Tetap di Tengkurap atau ke? Sesuai logika umum
                    Console.WriteLine("Sudah posisi paling bawah");
                    break;
                case State.Terbang:
                    currentState = State.Jongkok;
                    Console.WriteLine("posisi landing"); // KHUSUS NIM % 3 == 2: Terbang -> Jongkok
                    break;
            }
        }

        public void TekanTombolW()
        {
            Console.WriteLine("tombol arah atas ditekan"); // Output untuk NIM % 3 == 0

            switch (currentState)
            {
                case State.Berdiri:
                    currentState = State.Terbang;
                    Console.WriteLine("posisi take off"); // KHUSUS NIM % 3 == 2: Berdiri -> Terbang
                    break;
                case State.Jongkok:
                    currentState = State.Berdiri;
                    break;
                case State.Tengkurap:
                    currentState = State.Jongkok;
                    break;
                case State.Terbang:
                    Console.WriteLine("Sudah posisi paling atas");
                    break;
            }
        }

        public void TekanTombolX()
        {
            // Tombol khusus untuk langsung ke Tengkurap (jika diperlukan)
            switch (currentState)
            {
                case State.Terbang:
                case State.Berdiri:
                case State.Jongkok:
                    currentState = State.Tengkurap;
                    Console.WriteLine("Langsung tengkurap");
                    break;
            }
        }

        // Method untuk mendapatkan state saat ini
        public State GetCurrentState()
        {
            return currentState;
        }

        // Method untuk menampilkan state dengan output sesuai NIM
        public void TampilkanState()
        {
            string outputState = "";

            switch (currentState)
            {
                case State.Berdiri:
                    outputState = "Berdiri";
                    break;
                case State.Jongkok:
                    outputState = "Jongkok";
                    break;
                case State.Tengkurap:
                    outputState = "Tengkurap";
                    break;
                case State.Terbang:
                    outputState = "Terbang";
                    break;
            }

            Console.WriteLine($"State sekarang: {outputState}");

            // Untuk NIM % 3 == 2, tambahan output tertentu bisa di sini
            // Tapi sesuai soal, output khusus sudah di method TekanTombol
        }
    }
}

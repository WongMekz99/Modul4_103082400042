using System;

namespace Modul4_103082400042
{
    public class PosisiKarakterGame
    {
        public enum State { Jongkok, Berdiri, Tengkurap, Terbang }
        public State currentState;

        public PosisiKarakterGame()
        {
            currentState = State.Berdiri;
        }

        public void AktifkanTombol(string tombol)
        {
            // Output wajib sesuai aturan NIM % 3 == 0 (NIM 42)
            if (tombol == "TombolS")
            {
                Console.WriteLine("tombol arah bawah ditekan");
            }
            else if (tombol == "TombolW")
            {
                Console.WriteLine("tombol arah atas ditekan");
            }

            // Logika perpindahan State sesuai Diagram Hal. 4
            if (currentState == State.Berdiri && tombol == "TombolW")
            {
                currentState = State.Terbang;
            }
            else if (currentState == State.Terbang && tombol == "TombolS")
            {
                currentState = State.Berdiri;
            }
            else if (currentState == State.Berdiri && tombol == "TombolS")
            {
                currentState = State.Jongkok;
            }
            else if (currentState == State.Jongkok && tombol == "TombolW")
            {
                currentState = State.Berdiri;
            }
            else if (currentState == State.Jongkok && tombol == "TombolS")
            {
                currentState = State.Tengkurap;
            }
            else if (currentState == State.Tengkurap && tombol == "TombolW")
            {
                currentState = State.Jongkok;
            }
            else if (currentState == State.Terbang && tombol == "TombolX")
            {
                currentState = State.Jongkok;
            }
        }
    }
}
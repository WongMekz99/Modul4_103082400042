using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103082400042
{
    internal class PosisiKarakterGame
    {
        // Definisi semua kemungkinan posisi (State)
        public enum State { Jongkok, Berdiri, Tengkurap, Terbang }
        public State currentState;

        public PosisiKarakterGame()
        {

            currentState = State.Berdiri;
        }

        public void AktifkanTombol(string tombol)
        {
            if (tombol == "TombolS")
            {
                Console.WriteLine("tombol arah bawah ditekan");
            }
            else if (tombol == "TombolW")
            {
                Console.WriteLine("tombol arah atas ditekan");
            }

            // Aturan perpindahan state sesuai diagram halaman 4
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

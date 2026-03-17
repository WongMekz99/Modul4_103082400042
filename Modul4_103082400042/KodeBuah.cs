using System;
using System.Collections.Generic;

namespace Modul4_103082400042
{
    internal class KodeBuah
    {
        // Tabel data Buah (Teknik Table-Driven) 
        private Dictionary<string, string> tabelBuah = new Dictionary<string, string>()
        {
            {"Apel", "A00"}, {"Aprikot", "B00"}, {"Alpukat", "C00"},
            {"Pisang", "D00"}, {"Paprika", "E00"}, {"Blackberry", "F00"},
            {"Ceri", "H00"}, {"Kelapa", "I00"}, {"Jagung", "J00"},
            {"Kurma", "K00"}, {"Durian", "L00"}, {"Anggur", "M00"},
            {"Melon", "N00"}, {"Semangka", "O00"}
        };

        // Method untuk mengambil kode buah 
        public string getKodePos(string namaBuah)
        {
            if (tabelBuah.ContainsKey(namaBuah))
            {
                return tabelBuah[namaBuah];
            }
            return "Buah tidak ditemukan";
        }
    }
}
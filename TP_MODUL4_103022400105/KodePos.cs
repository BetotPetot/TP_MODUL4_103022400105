using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400105
{
    internal class KodePos
    {
        // Array yang berisi daftar nama kelurahan
        string[] kelurahan = {
            "Batununggal", "Kujangsari", "Mengger",
            "Wates", "Cijaura", "Jatisari",
            "Margasari", "Sekejati", "Kebonwaru", "Maleer"
        };

        // Array yang berisi kode pos yang sesuai dengan kelurahan, posisi index juga sama dengan array kelurahan
        int[] kodePos = {
            40266, 40287, 40267,
            40256, 40287, 40286,
            40286, 40286, 40272, 40274
        };

        // Method untuk mendapatkan kode pos berdasarkan nama kelurahan
        public int getKodePos(String kel) {
            // Melakukan perulangan untuk mencari kelurahan yang sesuai
            for (int i = 0; i < kelurahan.Length; i++) {
                // Jika nama kelurahan pada array sama dengan input user
                if (kelurahan[i] == kel) {
                    // Mengembalikan kode pos yang berada pada index yang samaD
                    return kodePos[i];
                }
            }
            // Jika kelurahan tidak ditemukan, method mengembalikan -1
            return -1;
        }
    }
}

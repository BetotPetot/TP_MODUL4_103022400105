using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400105
{
    internal class KodePos
    {
        string[] kelurahan = {
            "Batununggal", "Kujangsari", "Mengger",
            "Wates", "Cijaura", "Jatisari",
            "Margasari", "Sekejati", "Kebonwaru", "Maleer"
        };

        int[] kodePos = {
            40266, 40287, 40267,
            40256, 40287, 40286,
            40286, 40286, 40272, 40274
        };

        public int getKodePos(String kel) {
            for (int i = 0; i < kelurahan.Length; i++) {
                if (kelurahan[i] == kel) { 
                    return kodePos[i];
                }
            } 
            return -1;
        }

    }
}

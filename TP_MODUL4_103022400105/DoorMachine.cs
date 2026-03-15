using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400105
{
    internal class DoorMachine
    {
        // Enum digunakan untuk mendefinisikan kemungkinan state dari pintu
        enum State { TERKUNCI, TERBUKA };

        // Variabel untuk menyimpan state pintu saat ini
        private State currentState;

        // Constructor dijalankan saat objek DoorMachine dibuat, state awal pintu adalah TERKUNCI
        public DoorMachine()
        {
            currentState = State.TERKUNCI;
            Console.WriteLine("Pintu terkunci");
        }

        // Method untuk membuka pintu
        public void BukaPintu()
        {
            // Mengecek state pintu saat ini
            switch (currentState)
            {
                // Jika pintu dalam keadaan terkunci
                case State.TERKUNCI:
                    // State berubah menjadi TERBUKA
                    currentState = State.TERBUKA;
                    Console.WriteLine("Pintu tidak terkunci");
                    break;

                // Jika pintu sudah terbuka
                case State.TERBUKA:
                    // Tidak ada perubahan state
                    Console.WriteLine("Pintu sudah terbuka");
                    break;
            }
        }

        // Method untuk mengunci pintu
        public void KunciPintu()
        {
            // Mengecek state pintu saat ini
            switch (currentState)
            {
                // Jika pintu dalam keadaan terbuka
                case State.TERBUKA:
                    // State berubah menjadi TERKUNCI
                    currentState = State.TERKUNCI;
                    Console.WriteLine("Pintu terkunci");
                    break;

                // Jika pintu sudah terkunci
                case State.TERKUNCI:
                    // Tidak ada perubahan state
                    Console.WriteLine("Pintu sudah terkunci");
                    break;
            }
        }
    }
}

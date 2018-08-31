using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotak_kotak
{
    class Program
    {
        static void Main(string[] args)
        {
            input.BuatKotak(6, 1, 113, 10);
            input.BuatKotak(6, 11, 20,30 );
            input.BuatKotak(22, 11, 113, 30);

            string judul = "Selamat Belajar";
            input.tulis_warna((120 - judul.Length) / 2, 2, judul,ConsoleColor.Green,ConsoleColor.Black);
            string subjudul = "Semoga cepat bisa";
            input.tulis((120 - subjudul.Length) / 2, 4, subjudul);

            input.tulis(9, 12, "PILIHAN");
            //aray pati nggnah
            string[] menu = new string[7];
            menu[0]="::Siswa::";
            menu[1]="::Dosen::";
            menu[2]="::Biaya::";
            menu[3]="::Matkul::";
            menu[4]="::nilai::";
            menu[5]="::Absen::";
            menu[6]="::Lulus::";

            for (int i = 1; i < menu.Length; i++)
            {
                input.tulis(9,13+i,menu[i]);
            }
            int pilihan = 0;
            input.tulis_warna(9, 13, menu[pilihan], ConsoleColor.Black, ConsoleColor.Green);
            //pencet tombol
            Console.CursorVisible = false;
            ConsoleKeyInfo tombol;
            do
            {
                tombol = Console.ReadKey(true);
                if (tombol.Key == ConsoleKey.DownArrow)
                {
                    input.tulis_warna(9, 13 + pilihan, menu[pilihan], ConsoleColor.White, ConsoleColor.Black);
                    pilihan++;
                    if (pilihan == 7)
                    {
                        pilihan = 0;
                    }
                    input.tulis_warna(9, 13 + pilihan, menu[pilihan], ConsoleColor.Black, ConsoleColor.Green);
                }


                if (tombol.Key == ConsoleKey.UpArrow)
                {
                    input.tulis_warna(9, 13 + pilihan, menu[pilihan], ConsoleColor.White, ConsoleColor.Black);
                    pilihan--;
                    if (pilihan == -1)
                    {
                        pilihan = 6;
                    }
                    input.tulis_warna(9, 13 + pilihan, menu[pilihan], ConsoleColor.Black, ConsoleColor.Green);
                }
                if (tombol.Key == ConsoleKey.Enter)
                {
                    if (pilihan == 0)
                    {
                        input.tulis(25, 13, "Masukan Nama:");
                    }
                    else if (pilihan == 1)
                    {
                        input.tulis(25, 14, "Echo");
                    }
                    else if (pilihan == 2)
                    {
                        input.tulis(25, 15, "Rp.150.000");
                    }
                    else if (pilihan == 3)
                    {
                        input.tulis(25, 16, "komputer");
                    }
                    else if (pilihan == 4)
                    {
                        input.tulis(25, 17, "nilai");
                    }
                }
            } while (tombol.Key != ConsoleKey.End);



            
            

            Console.ReadKey();
        }
        
            

    }
}

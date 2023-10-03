using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiVeNha2_7
{
    class Bai2_7
    {
        static void Main(string[] args)
        {
            int tienGui, soThangGui;
            double laiSuatNam;
            Console.WriteLine("Nhap vao so tien gui: ");
            tienGui = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("So thang muon gui: ");
            soThangGui = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lai suat mot nam: ");
            laiSuatNam = Convert.ToDouble(Console.ReadLine());
            double laiSuatThang;            
            double laiThang;
            laiSuatThang = (laiSuatNam / 12) / 100;
            double TongTien = tienGui;

            for (int i = 1; i <= soThangGui; i++)
            {
                laiThang = TongTien * laiSuatThang;
                Console.WriteLine("So tien lai thang {0} : {1}  ", i,laiThang);
                TongTien = TongTien + laiThang;
                Console.WriteLine("Tong tien den thang{0} : {1} ", i, TongTien);
            }

            Console.ReadKey();

        }
    }
}

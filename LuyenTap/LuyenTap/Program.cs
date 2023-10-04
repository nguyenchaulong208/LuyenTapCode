using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu:
            Console.Write("Chon bai toan: ");
            int bai = int.Parse(Console.ReadLine());
            if(bai == 1)
            {
                // Bài 1: Tính S(n) = 1 + 2 + 3 + … +n
                Console.WriteLine("Bai 1: Tinh S(n) = 1 + 2 + 3 + … + n");
                XuLy.ThongBao();
                int n = int.Parse(Console.ReadLine());
                int kq = XuLy.TinhTong(n);
                Console.WriteLine($"Ket qua la: {kq}");
            }
            if(bai == 2)
            {
                //Bài 2: Tính S(n) = 1 ^ 2 + 2 ^ 2 + … +n ^ 2
            }

        }
    }
}

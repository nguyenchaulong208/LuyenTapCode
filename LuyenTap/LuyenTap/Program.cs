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
            Console.WriteLine("1. Bai 1: Tinh S(n) = 1 + 2 + 3 + … + n");
            Console.WriteLine("2. Bai 2: Tinh S(n) = 1 ^ 2 + 2 ^ 2 + … +n ^ 2");
            Console.WriteLine("3. Bai 3: Tinh S(n) = 1 + ½ + 1/3 + … + 1/n");
            //Menu:
            Console.Write("Chon bai toan: ");
            int bai = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------");
            if (bai == 1)
            {
                // Bài 1: Tính S(n) = 1 + 2 + 3 + … +n
                Console.WriteLine("Bai 1: Tinh S(n) = 1 + 2 + 3 + … + n");
                
                int n = XuLy.Nhap();
                int kq = XuLy.TinhTong(n);
                Console.WriteLine($"Ket qua la: {kq}");
            }
            if(bai == 2)
            {
                //Bài 2: Tính S(n) = 1 ^ 2 + 2 ^ 2 + … +n ^ 2
                Console.WriteLine("Bai 2: Tinh S(n) = 1 ^ 2 + 2 ^ 2 + … +n ^ 2");
                int n = XuLy.Nhap();
                int kq = XuLy.LuyThua(n);
                Console.WriteLine($"Ket qua la: {kq}");
            }
            if(bai == 3)
            {
                int n = XuLy.Nhap();
                double kq = XuLy.PhanSo(n);
                Console.WriteLine($"Ket qua la: {kq}");
            }
        }
    }
}

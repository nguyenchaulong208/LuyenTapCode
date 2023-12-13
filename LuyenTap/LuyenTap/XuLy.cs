using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap
{
    internal class XuLy
    {
        public static int Nhap()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        
        public static int TinhTong(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }
            return s;
        }
        public static int LuyThua(int n)
        {
            int lt = 0;
            for (int i = 1; i <= n; i++)
            {
                lt = lt + i * i;
            }
            return lt;

        }
        public static double PhanSo(int n)
        {
            double thuong = 0.0f;
            double ps = 0.0f;
            for (int i = 1; i <= n; i++)
            {
                thuong = 1 / i;
                ps =  ps + thuong;
            }
            return ps;
        }
    }
}

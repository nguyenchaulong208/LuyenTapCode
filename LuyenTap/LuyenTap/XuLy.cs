using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap
{
    internal class XuLy
    {
        
        public static void ThongBao()
        {
            Console.Write("Nhap n: ");
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
        
    }
}

using PhanSo_Nhom1_De1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Giua_Ky
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PhanSo macdinh = new PhanSo();
            PhanSo xts = new PhanSo();
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();
            PhanSo tong = new PhanSo();
            PhanSo hieu = new PhanSo();

            Console.WriteLine("Nhap phan so thu 1: ");
            ps1.Nhap();
            Console.WriteLine("Nhap phan so thu 2: ");
            ps2.Nhap();
            Console.WriteLine("Nhập phân số thứ 3:");
            xts.Nhap1tx();

            macdinh.ToString();
            Console.WriteLine("Phân số mặc định là:" + macdinh.ToString());
            xts.ToString();
            Console.WriteLine("Khởi tạo 1 tham số là:" + xts.ToString());


            ps1.ToString();
            Console.WriteLine("Phân số đầu tiên là:" + ps1.ToString());
            ps1.RutGon();
            Console.WriteLine("Phân số đầu tiên được rút gọn là:" + ps1.ToString());
            ps3 = ps1.giatri();
            Console.WriteLine("Phân số đầu tiên được trả về là:" + ps3.xuatgiatri());

            ps2.ToString();
            Console.WriteLine("Phân số thứ hai là:" + ps2.ToString());
            ps2.RutGon();
            Console.WriteLine("Phân số thứ hai được rút gọn là:" + ps2.ToString());
            ps3 = ps2.giatri();
            Console.WriteLine("Phân số đầu tiên được trả về là:" + ps3.xuatgiatri());


            tong = PhanSo.Cong(ps1, ps2);
            ps1.ToString();
            Console.Write(" cong ");
            ps2.ToString();
            Console.Write(" = ");
            tong.RutGon();
            tong.Xuat();
            Console.WriteLine();
            ps3 = tong.NghichDao();
            Console.WriteLine("Phân số cộng được nghịch đảo là:" + ps3.XuatGiaTri(tong));


            hieu = PhanSo.Tru(ps1, ps2);
            ps1.ToString();
            Console.Write(" tru ");
            ps2.ToString();
            Console.Write(" = ");
            hieu.RutGon();
            hieu.Xuat();
            Console.WriteLine();
            ps3 = hieu.NghichDao();
            Console.WriteLine("Phân số trừ được nghịch đảo là:" + ps3.XuatGiaTri(hieu));

            Console.ReadLine();
        }
    }
}


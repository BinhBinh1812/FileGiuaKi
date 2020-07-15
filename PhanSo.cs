using System; bạn Bình đã sửa
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PhanSo_Nhom1_De1
{
    public class PhanSo
    {
        private Int32 tuSo;
        private Int32 mauSo;

        public Int32 TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }
        public Int32 MauSo
        {
            get { return mauSo; }
            set
            {
                if (value != 0)
                    mauSo = value;
            }

        }
        public void Nhap()
        {
            Console.WriteLine("Mời bạn nhập tử số: ");
            tuSo = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Mời bạn nhập mẫu số: ");
                mauSo = Convert.ToInt32(Console.ReadLine());
                if (mauSo == 0)
                {
                    Console.WriteLine("Mẫu số phải khác 0. Vui lòng nhập lại!");
                }
            } while (mauSo == 0);

        }
        public void Nhap1tx()
        {
            Console.WriteLine("Mời bạn nhập tử số: ");
            TuSo = Convert.ToInt32(Console.ReadLine());
        }
        //Hàm khởi tạo mặc định
        public PhanSo()
        {
            this.tuSo = 0;
            this.mauSo = 1;
        }
        //Hàm khởi tạo 2 tham số

        public PhanSo(Int32 TuSo, Int32 MauSo)
        {
            this.tuSo = TuSo;
            this.mauSo = MauSo;
        }

        //Hàm khởi tạo 1 tham số

        public PhanSo(Int32 x)
        {
            this.tuSo = x;
            this.mauSo = 1;
        }
        //Phương thức cộng    
        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo Cong = new PhanSo();

            Cong.tuSo = a.tuSo * b.mauSo + a.mauSo * b.tuSo;
            Cong.mauSo = a.mauSo * b.mauSo;
            return Cong;
        }
        //Phương thức trừ
        public static PhanSo Tru(PhanSo a, PhanSo b)
        {
            PhanSo Tru = new PhanSo();
            Tru.tuSo = a.tuSo * b.mauSo - a.mauSo * b.tuSo;
            Tru.mauSo = a.mauSo * b.mauSo;
            return Tru;
        }

        public void Xuat()
        {
            Console.WriteLine(tuSo + "/" + mauSo);
        }
        //Tìm ước số chung lớn nhất
        public Int32 USLN(Int32 a, Int32 b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        //Hàm rút gọn 2 phân số
        public void RutGon()
        {
            Int32 uscl = USLN(Math.Abs(tuSo), Math.Abs(mauSo));
            tuSo = tuSo / uscl;
            mauSo = mauSo / uscl;
        }
        //Hàm trả về số thực
        public PhanSo giatri()
        {
            //// trả về giá trị của phân số hiện tại
            return new PhanSo(this.tuSo, this.mauSo);

        }
        //Xuất giá trị số thực
        public double xuatgiatri()
        {
            return 1.0 * tuSo / mauSo;
        }

        //Hàm nghịch đảo
        public PhanSo NghichDao()
        {
            if (this.tuSo == 0) // nếu tử số = 0 thì trả về 0. vì khi nghịch đảo mấu số không được phép = 0
                return new PhanSo(0, 0);

            return new PhanSo(this.mauSo, this.tuSo); // trả về phân số nghịch đảo có dạng: mauso / tuso
        }
        //Xuất giá trị nghịch đảo
        public PhanSo XuatGiaTri(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = ps.mauSo;
            kq.mauSo = ps.tuSo;
            return kq;
        }

        public override string ToString()
        {
            return string.Format(tuSo + "/" + mauSo);
        }
    }
}

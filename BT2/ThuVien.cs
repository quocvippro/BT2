using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class ThuVien
    {
        Sach s = new Sach();
        List<Sach> ds = new List<Sach>();
        
        public void themsach() { 
           
            Console.WriteLine("Nhap so luong sach :");
            int n=Convert.ToInt32(Console.ReadLine());  
            for (int i = 0; i < n; i++)
            {
              
                Console.WriteLine("Nhap sach "+(i+1)+" : ");
                Console.Write("Nhap ma:");
                s.masach=Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap ten:");
                s.tensach = Console.ReadLine();
                Console.Write("Nhap tac gia:");
                s.tacgia = Console.ReadLine();



            }
        }
        public void htsach()
        {
            Console.WriteLine("Hien thi"); 
            foreach (Sach s in ds)
            {
                Console.WriteLine(s);
            }
            
        }
        static void Main(string[] args)
        {
            ThuVien tv = new ThuVien();
            Console.ReadKey();
        }
        
    }
}

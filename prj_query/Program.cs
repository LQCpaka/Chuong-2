using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mang = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
            string[] mangchuoi = { "dau", "long", "hai", "a", "to", "nga", "Thuy", "Kieu", "la", "chi", "em", "la", "Thuy", "Van" };
            //Cau 1:
            //cau1a(mang);

            //Cau 2:
            //cau2a(mang);

            //Cau 3:
            //cau3a(mang);

            //Cau 4:
            //cau4a(mang);

            //Cau 5:
            cau5a(mangchuoi);

            //Cau 6:
            //cau6a(mangchuoi);

            //Cau 7:
            //cau7a(mangchuoi);

            //Cau 8:
            //cau8a(mangchuoi);
            Console.ReadKey();
        }

        private static void cau8a(string[] mangchuoi)
        {
            var kq = from s in mangchuoi
                     where s.Substring(0,1) == s.Substring(0,1).ToUpper()
                     orderby s.Substring(0, 1)
                     select s.ToLower() + "-" + s.ToUpper();

            kq.ToList().ForEach(x => Console.Write("{0,15}", x));
        }

        private static void cau7a(string[] mangchuoi)
        {
            var kq = from s in mangchuoi
                     where s.Contains("u")
                     orderby s.Substring(0, 1)
                     select s.ToLower() + "-" + s.ToUpper();

            kq.ToList().ForEach(x => Console.Write("{0,15}", x));
        }

        private static void cau6a(string[] mangchuoi)
        {
            var kq = from s in mangchuoi
                     where s.Length == 4
                     orderby s.Substring(0, 1)
                     select s.ToLower() + "-" + s.ToUpper();
            
            kq.ToList().ForEach(x => Console.Write("{0,15}", x));
        }

        private static void cau5a(string[] mangchuoi)
        {
            var kq = from s in mangchuoi
                     where s.Length == 4
                     orderby s.Substring(0, 1)
                     select s;
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }

        private static void cau4a(int[] mang)
        {
            var kq = from n in mang
                     select n % 2 == 0? n / 2 : n;
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }

        private static void cau3a(int[] mang)
        {
            Console.Write("Nhap mot so nguyen: ");
            int a = int.Parse(Console.ReadLine());
            var kq = from n in mang
                     where n > a
                     orderby n
                     select n;
            kq.ToList().ForEach(x => Console.Write("{0,5}", x));
        }

        private static void cau2a(int[] mang)
        {
            Console.Write("Nhap mot so nguyen: ");
            int a = int.Parse(Console.ReadLine());
            var kq = from n in mang
                     where n < a
                     orderby n
                     select n;
            kq.ToList().ForEach(x => Console.Write("{0,5}",x));
        }
        private static void cau1a(int[] mang)
        {
            var kq = from n in mang
                     where n % 4 == 0 && n % 3 == 0
                     select n;
            kq.ToList().ForEach(x => Console.Write("{0,5}",x));
        }
    }
}

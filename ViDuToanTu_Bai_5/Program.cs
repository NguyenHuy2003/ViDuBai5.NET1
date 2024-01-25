using System;
using System.Text;

namespace ViDuToanTu_Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Ví dụ Câu lệnh switch
            Console.WriteLine("Ví dụ: Câu lệnh switch");
            int number = 3;
            switch (number)
            {
                case 1:
                    Console.WriteLine("number có giá trị một");
                    break;
                case 2:
                    Console.WriteLine("number có giá trị hai");
                    break;
                default:
                    Console.WriteLine("number khác một và hai");
                    break;

            }
            Console.WriteLine("-------------------------------");

            // Ví dụ câu lệnh 3 thành phần
            Console.WriteLine("Ví dụ: Câu lệnh 3 thành phần");
            var a1 = 10;
            var b1 = 9;
            var c1= 11;
            
            var max = (a1 >= b1) ?  (a1 >= c1 ? a1 : c1) : (b1 >=c1 ? b1 : c1);
            Console.WriteLine("Giá trị max = " + max);
            Console.WriteLine("-------------------------------");

            //Ví dụ Câu điều kiện
            Console.WriteLine("Ví dụ 1: Câu điều kiện if đơn giản");
            int n = 2024;
            if (n % 2 == 0) {
                Console.WriteLine("Số " + n + " chia hết cho 2");
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Ví dụ 2: Câu điều kiện if else");
            int m = 26;
            int k = 12;
            if (m < k)
            {
                Console.WriteLine("m = " + m + " nhỏ hơn " + " k = " + k);
            }
            else
            {
                Console.WriteLine("m = " + m + " lớn hơn hoặc bằng " + " k = " + k);
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Ví dụ 3: Câu điều kiện if, else if, else");
            
            if (m < k)
            {
                Console.WriteLine("m = " + m + " nhỏ hơn " + " k = " + k);
            }
            else if (m == k) 
            {
                Console.WriteLine("m = " + m + " bằng " + " k = " + k);
            }
            else
            {
                Console.WriteLine("m = " + m + " lớn hơn " + " k = " + k);
            }
            Console.WriteLine("-------------------------------");

            bool x = true;
            bool y = false;

            Console.WriteLine("x && y:" + (x && y));
            Console.WriteLine("x || y:" + (x || y));
            Console.WriteLine("!x: " + (!x));
            Console.WriteLine("!y:" + (!y));



            int a = 26;
            int b = 12;

          

            //So sánh bằng
            bool c = (a == b);
            Console.WriteLine("a có bằng b: " + c);
            bool d = (a > b);
            Console.WriteLine("a lớn hơn b: " + d);
            bool g = (a >= b);
            Console.WriteLine("a lớn hơn hoặc bằng b: " + g);
            bool e = (a < b);
            Console.WriteLine("a nhỏ hơn b: " + e);
            bool h = (a < b);
            Console.WriteLine("a nhỏ hơn hoặc bằng b: " + h);
            bool f = (a != b);
            Console.WriteLine("a khác b: " + f);






        }
    }
}

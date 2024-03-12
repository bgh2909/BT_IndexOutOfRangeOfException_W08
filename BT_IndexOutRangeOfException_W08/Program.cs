using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_IndexOutRangeOfException_W08
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            int[] arr = new int[10];

            List<string> stringList = new List<string>(); //khởi tạo list (list tùy biến thoải mái hơn)
            //mảng thuộc kiểu stack, list thuộc kiểu tham chiếu, chiếm bộ nhớ hơn (không nên dùng list nhiều)
            stringList.Add("A");//thêm phần tử vào list
            stringList.Add("B");//thêm phần tử vào list
            stringList.Add("C");//thêm phần tử vào list
            stringList.Clear();//xóa list

            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6];

            }

            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex);
            }
        }
    }
}

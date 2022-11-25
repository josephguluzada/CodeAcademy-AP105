using System.Linq;
using System.Text;

namespace StringArrayCharMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //char[] chars = { 'A', 'P', '1', '0', '5' };

            //string newStr = new string(chars);

            //Console.WriteLine(newStr);


            #region String Methods
            string str = "Ab 102 Ab1   "; // ab102

            str = "Ap";
            string str2 = "102";

            str = str +str2;
            Console.WriteLine(str);
            #endregion

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Ap");
            stringBuilder.Append(str2);

            stringBuilder.Remove(0,2);


            Console.WriteLine(stringBuilder);
        }
    }
}
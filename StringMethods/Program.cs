using System.Text;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = "        EverytHing  i neeD,    is a CuP   of       CoFFee    ";

            Console.WriteLine(StringFormat(inputText));
        }

        public static string StringFormat(string input)
        {
            input=input.Trim().ToUpper();
            string[] text = input.Split(' ');

            StringBuilder result=new StringBuilder();


            foreach (var item in text)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string newItem = item[0] + item.Substring(1).ToLower();
                    result.Append(newItem+' ');
                }
            }
            return result.ToString();
        }

    }
}
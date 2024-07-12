using System;

namespace AulaDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99887766";

            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine($"Size: {cookies.Count}");

            Console.WriteLine("ALL COOKIES: ");

            foreach (KeyValuePair<string, string> item in cookies)//KeyValue pode ser alterado por "var"
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
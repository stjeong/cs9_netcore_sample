using System;

class Program
{
    static void Main(string[] args)
    {
        {
            // string title = "console: ";

            Func<int, string> func = static i =>
            {
                // Error CS8820  A static anonymous function cannot contain a reference to 'title'.
                // return title + i.ToString();

                return i.ToString();
            };

            Console.WriteLine(func(10));
        }

        {
            const string title = "console: ";

            Func<int, string> func = static delegate (int i)
            {
                // const 변수의 경우 참조에 대한 부작용이 없으므로 사용 가능
                return title + i.ToString();
            };

            Console.WriteLine(func(10));
        }
    }
}


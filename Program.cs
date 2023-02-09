











namespace Lesson
{
    class program
    {
        public static void Main(string[] args)
        {
            double a = 1;
            double b = 5.3;

            Console.WriteLine($"a = {a}\t b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}\t b = {b}");

            Console.WriteLine("\n");

            string str1 = "Hello";
            string str2 = "world";

            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");

            //Foo<T>();
            // Foo<int>(); // в данном случае нужно явно указать тип данных (т.к. мы Т использовали как string )
            int result = Foo<int>();
        }

        static void Swap<T>(ref T a, ref T b) // принемает параметры
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static T Foo<T>() // возвращает значения, но не принимает параметры
        {
          /*  if (true) // если Т не выполнилось
            {
                return default(T); // возвращаеться дефолтное значение
            }
          */
            return default(T);
        }

    }
}
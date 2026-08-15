namespace FirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            Book book = new Book();
            object obj = book;
            Console.WriteLine(obj);

            #endregion

            #region Question 2

            Console.WriteLine(book.ToString());

            Console.WriteLine(book.Equals(book));

            Console.WriteLine(book.GetHashCode());

            Console.WriteLine(book.GetType());

            #endregion

            #region Question 3

            // Compile-time error
            // int pages = "464";

            int pages = 464;

            #endregion

            #region Question 4

            int x = 10;
            int y = 0;
            try
            {
                int z = x / y;
                Console.WriteLine($"Result: {z}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Cannot divide by zero: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Done .");
            }
            #endregion

            #region Question 5

            int Pages = 300;
            double PagesAsDouble = Pages;
            Console.WriteLine($"Pages as double: {PagesAsDouble}");

            #endregion

            #region Question 6

            double price = 49.99;
            int priceAsInt = (int)price;
            Console.WriteLine($"Price as int: {priceAsInt}");

            #endregion

            #region question 7

            string pagesText = "464";
            int pagesNumber = Convert.ToInt32(pagesText);
            Console.WriteLine($"Pages as number: {pagesNumber}");

            #endregion

            #region Question 8

            string textYear = "2023";
            string badText = "abc";

            int year = int.Parse(textYear);
            bool text = int.TryParse(badText, out int badValue);

            if (text)
            {
                Console.WriteLine($"Parsed year: {year}");
            }
            else
            {
                Console.WriteLine($"Invalid number: {badValue}");
            }

            #endregion

            #region Question 9

            int page = 464;

            string pageAsString = page.ToString();

            Console.WriteLine($"Page as string: {pageAsString}");
            Console.WriteLine(pageAsString.GetType());

            #endregion 

            #region Question 10

            int copies = 100;

            object boxedCopies = copies; // Boxing

            Console.WriteLine($"Boxed copies: {boxedCopies}");

            int unboxedCopies = (int)boxedCopies; // Unboxing

            Console.WriteLine($"Unboxed copies: {unboxedCopies}");

            #endregion

            #region Question 11
            int? nullableYear = null;

            Console.WriteLine($"Has value: {nullableYear.HasValue}");

            nullableYear = 2023;

            Console.WriteLine($"Year: {nullableYear}");

            #endregion

            #region Question 12

            string? reviewer = null;

            Console.WriteLine($"Is reviewer null? {reviewer == null}");

            #endregion

        }
    }

}


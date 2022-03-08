using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;

namespace ExtractBookCode
{
    class BookId
    {
        public int DepartmentCode { get; set; }
        public int YearOfPublication { get; set; }
        public int PageCount { get; set; }
        public string ID { get; set; }

        private BookId(int deptCode, int publicationYear, int pageCount, string id)
        {
            this.DepartmentCode = deptCode;
            this.YearOfPublication = publicationYear;
            this.PageCount = pageCount;
            this.ID = id;
        }

        private static int parseDepatmentCode(string id) => int.Parse(id.Substring(0, 3));
        private static int parsePublicationYear(string id) => int.Parse(id.Substring(3, 4));
        private static int parsePageNumber(string id) => int.Parse(id.Substring(7, 5));
        private static string parseBookId(string id) => id.Substring(12);
        private static bool isValidPublicationYear(int year) => year >= 1990 && year <= 2020;
        private static bool isValidDepartment(int code) => new HashSet<int>() { 101, 102, 103 }.Contains(code);
        private static bool isValidPage(int pageNumber) => pageNumber >= 1 && pageNumber <= 99999;
        private static bool isValidBookId(string id) => new Regex(@"^[A-Z]{1}\d{5}$").IsMatch(id);
        public static BookId Parse(string bookID)
        {
            if (bookID.Length != 18) throw new Exception("Invalid Book Code");

            var departmentCode = parseDepatmentCode(bookID);
            var publicationYear = parsePublicationYear(bookID);
            var pageNumber = parsePageNumber(bookID);
            var id = parseBookId(bookID);

            if (!isValidDepartment(departmentCode)) Console.WriteLine(" Invalid Department Code");
            else Console.WriteLine($"Department Code\t:{departmentCode}");

            if (!isValidPublicationYear(publicationYear)) Console.WriteLine("Invalid Year");
            else Console.WriteLine($"\nYear of Publication\t:{publicationYear}");

            if (!isValidPage(pageNumber)) Console.WriteLine("Invalid Page Numbers");
            else Console.WriteLine($"\nNumber of Pages\t:{pageNumber}");

            if (!isValidBookId(id)) Console.WriteLine("Invalid Book ID");
            else Console.WriteLine($"\nBook ID\t:{id}");

            return new ExtractBookCode.BookId(departmentCode, publicationYear, pageNumber, id);
        }
    }

    public class Program
    {
        public static void Main(String[] arg)
        {
            Console.WriteLine("Enter the book code of length 18");
            var bookID = Console.ReadLine();

            try
            {
                BookId.Parse(bookID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            };
        }
    }
}
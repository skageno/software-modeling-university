class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        Book book1 = new Book(1, " BookName1");
        books.Add(book1);
        Book book2 = new Book(2, " BookName2");
        books.Add(book2);
        foreach (Book b in books)
        {
            Console.WriteLine(b);
        }
        List<Annotated> annotations = new List<Annotated>();
        Annotated annotation1 = new Annotated(1, " AnnotationText1", 2);
        annotations.Add(annotation1);
        Annotated annotation2 = new Annotated(2, " AnnotationText2", 1);
        annotations.Add(annotation2);
        foreach (Annotated a in annotations)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine("*******************************************");
        foreach (Book b in books)
        {
            Console.WriteLine(b);
            foreach (Annotated a in annotations)
            {
                if (b.ID == a.BookID)
                {
                    Console.WriteLine("\t" + a);
                }
            }
        }
    }
}
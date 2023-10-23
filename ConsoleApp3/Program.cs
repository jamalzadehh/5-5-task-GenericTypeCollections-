namespace ConsoleApp3
{
}

    
    //class Program
    //{
    //    static void Main()
    //    {
    //        List<Library> libraries = new List<Library>();
    //        List<Category> categories = new List<Category>();
    //        List<Book> books = new List<Book>();

    //        while (true)
    //        {
    //            Console.WriteLine("1. Yeni kitabxana yarat");
    //            Console.WriteLine("2. Yeni kategoriya yarat");
    //            Console.WriteLine("3. Yeni kitab yarat");
    //            Console.WriteLine("4. Kitabxanaya daxil ol");
    //            Console.WriteLine("5. Proqramdan cix");
    //            Console.Write("Buyurun: ");

    //            string choice = Console.ReadLine();

    //            try
    //            {
    //                switch (choice)
    //                {
    //                    case "1":
    //                        Console.Write("Kitabxananin adini daxil edin: ");
    //                        string libraryName = Console.ReadLine();
    //                        if (string.IsNullOrEmpty(libraryName))
    //                        {
    //                            throw new WrongInputException("Ad bosh ola bilmez!");
    //                        }
    //                        libraries.Add(new Library(libraryName));
    //                        Console.WriteLine("Kitabxana yaradildi");
    //                        break;
    //                    case "2":
                            
    //                        Console.Write("Kateqoriyanin adini daxil edin: ");
    //                        string categoryName = Console.ReadLine();
    //                        if (string.IsNullOrEmpty(categoryName))
    //                        {
    //                            throw new WrongInputException("Ad bosh ola bilməz");
    //                        }
    //                        categories.Add(new Category(categoryName));
    //                        Console.WriteLine("Kateqoriya yaradildi");
    //                        break;
    //                    case "3":
    //                        Console.Write("Kitabin adini daxil edin: ");
    //                        string bookName = Console.ReadLine();
    //                        Console.Write("Yazari daxil edin: ");
    //                        string author = Console.ReadLine();
    //                        Console.Write("Kateqoriyani secin: ");
    //                        foreach (var category in categories)
    //                        {
    //                            Console.WriteLine($"{category.GetId()}. {category.GetName()}");
    //                        }
    //                        int categoryId;
    //                        if (!int.TryParse(Console.ReadLine(), out categoryId))
    //                        {
    //                            throw new WrongInputException("Daxil edilən bolme tam eded olmalidir");
    //                        }
    //                        Category selectedCategory = categories.Find(c => c.GetId() == categoryId);
    //                        if (selectedCategory == null)
    //                        {
    //                            throw new CategoryNotFoundException("Daxil edilen kategoriya tapilmadi");
    //                        }
    //                        books.Add(new Book(bookName, author, selectedCategory));
    //                        Console.WriteLine("Kitab yaradildi");
    //                        break;
    //                    case "4":
    //                        Console.Write("Kitabxanani secin: ");
    //                        foreach (var library in libraries)
    //                        {
    //                            Console.WriteLine($"{library.GetId()}. {library.GetName()}");
    //                        }
    //                        int libraryId;
    //                        if (!int.TryParse(Console.ReadLine(), out libraryId))
    //                        {
    //                            throw new WrongInputException("Daxil edilen bolme tam eded olmalidir");
    //                        }
    //                        Library selectedLibrary = libraries.Find(l => l.GetId() == libraryId);
    //                        if (selectedLibrary == null)
    //                        {
    //                            throw new LibraryNotFoundException("Daxil edilmish kitabxana tapilmadi");
    //                        }
    //                        while (true)
    //                        {
    //                            Console.WriteLine("1. Kitab elave et");
    //                            Console.WriteLine("2. Kitablari goster");
    //                            Console.WriteLine("3. Kitabxanadan cix");
    //                            Console.Write("Buyrun: ");
    //                            string libraryChoice = Console.ReadLine();
    //                            switch (libraryChoice)
    //                            {
    //                                case "1":
                                        
    //                                    Console.Write("Kitabi secin: ");
    //                                    foreach (var book in books)
    //                                    {
    //                                        Console.WriteLine($"{book.GetId()}. {book.GetName()}");
    //                                    }
    //                                    int bookId;
    //                                    if (!int.TryParse(Console.ReadLine(), out bookId))
    //                                    {
    //                                        throw new WrongInputException("Daxil edilen deyer tam eded olmalidir");
    //                                    }
    //                                    Book selectedBook = books.Find(b => b.GetId() == bookId);
    //                                    if (selectedBook == null)
    //                                    {
    //                                        throw new BookNotFoundException("Daxil edilmish kitab tapilmadi");
    //                                    }
    //                                    if (selectedLibrary._books.Contains(selectedBook))
    //                                    {
    //                                        throw new BookAlreadyExistsException("Bu kitab  kitabxanada var");
    //                                    }
    //                                    selectedLibrary._books.Add(selectedBook);
    //                                    Console.WriteLine("Kitab kitabxanaya əlave edildi");
    //                                    break;
    //                                case "2":
                                      
    //                                    Console.WriteLine("Kitablar:");
    //                                    foreach (var book in selectedLibrary._books)
    //                                    {
    //                                        Console.WriteLine($"{book.GetId()}. {book.GetName()}");
    //                                    }
    //                                    break;
    //                                case "3":
    //                                    Console.WriteLine("Yene gozleyirik <3");
    //                                    return;
    //                                    //Muellim burda nese alemi bir birine vurmusham 
    //                            }
    //                        }
                            
    //                    case "5":
    //                        Console.WriteLine("Yene gozleyirik <3");
                            
    //                        return;
    //                    default:
    //                        throw new WrongInputException("Daxil edilen melumat movcud deyil");
    //                }
    //            }
    //            catch (WrongInputException ex)
    //            {
    //                Console.WriteLine(ex.Message);
    //            }
    //            catch (BookAlreadyExistsException ex)
    //            {
    //                Console.WriteLine(ex.Message);
    //            }
    //            catch (BookNotFoundException ex)
    //            {
    //                Console.WriteLine(ex.Message);
    //            }
    //            catch (CategoryNotFoundException ex)
    //            {
    //                Console.WriteLine(ex.Message);
    //            }
    //            catch (LibraryNotFoundException ex)
    //            {
    //                Console.WriteLine(ex.Message);
    //            }
    //        }
    //    }
    //}

    //class Base
    //{
    //    private static int _lastId = 0;
    //    protected int Id;
    //    protected string Name;

    //    protected Base(string name)
    //    {
    //        Id = ++_lastId;
    //        Name = name;
    //    }

    //    public int GetId()
    //    {
    //        return Id;
    //    }

    //    public string GetName()
    //    {
    //        return Name;
    //    }
    //}

    //class Library : Base
    //{
    //    public List<Book> _books;

    //    public Library(string name) : base(name)
    //    {
    //        _books = new List<Book>();
    //    }
    //}

    //class Category : Base
    //{
    //    public Category(string name) : base(name)
    //    {
    //    }
    //}

    //class Book : Base
    //{
    //    public string Author;
    //    public Category Category;

    //    public Book(string name, string author, Category category) : base(name)
    //    {
    //        Author = author;
    //        Category = category;
    //    }
    //}

    //class BookAlreadyExistsException : Exception
    //{
    //    public BookAlreadyExistsException(string message) : base(message)
    //    {
    //    }
    //}

    //class BookNotFoundException : Exception
    //{
    //    public BookNotFoundException(string message) : base(message)
    //    {
    //    }
    //}

    //class CategoryNotFoundException : Exception
    //{
    //    public CategoryNotFoundException(string message) : base(message)
    //    {
    //    }
    //}

    //class LibraryNotFoundException : Exception
    //{
    //    public LibraryNotFoundException(string message) : base(message)
    //    {
    //    }
    //}

    //class WrongInputException : Exception
    //{
    //    public WrongInputException(string message) : base(message)
    //    {
    //    }
    //}
    

//task1
//class Program
    //{
    //    static void Main()
    //    { 
    //        Dictionary<string, int> programmingLanguages = new Dictionary<string, int>
    //    {
    //        { "C", 1972 },
    //        { "C++", 1983 },
    //        { "Python", 1991 },
    //        { "Java", 1995 },
    //        { "C#", 2000 },
    //        { "Go", 2009 }
    //    };

            
    //        var sortedLanguages = programmingLanguages.OrderBy(language => language.Value);

            
    //        Console.WriteLine("Artan sira ile diller:");
    //        foreach (var language in sortedLanguages)
    //        {
    //            Console.WriteLine($"{language.Key}: {language.Value}");
    //        }
    //    }
    //}
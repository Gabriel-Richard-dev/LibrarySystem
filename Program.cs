using System;
using System.Collections;
using System.Text;


namespace LibrarySystem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var pg = new Program();
            var usuario = new User("Gabriel", 001);
            usuario.MostraLivros();
            var hbts = new Book("Habitos Atomicos", 001, 3);
            usuario.PegarLivro(hbts, pg.LivroNaEstante(hbts));
            usuario.MostraLivros();
            
        }

        public bool LivroNaEstante(Book livro)
        {
            if (livro.GetCopys() > 0)
            {
                return true;
            }

            return false;
        }
    }

    class User
    {
        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }
        private string Name { get; set; }
        private int Id { get; set; }

        private ArrayList books = new ArrayList();

        public void MostraLivros()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("You dont have no one book");
            }
            foreach(string bks in books)
            {
                Console.WriteLine(bks);
            }
        }
        public void PegarLivro(Book livro, bool permissao)
        {
            if (permissao == true)
            {
                books.Add(livro.GetTitle());    
                livro.emprestaTitle();
            }
            
        } 

    }

    class Book
    {
        public Book(string title, int id, int cpavali)
        {
            Title = title;
            Id = id;
            CopyAvaliables = cpavali;
        }
        
        private string Title { get; set; }
        private int Id { get; set; }
        private int CopyAvaliables { get; set; }

        public string GetTitle()
        {
            return Title;
        }

        public int GetCopys()
        {
            return CopyAvaliables;
        }

        public void emprestaTitle()
        {
            CopyAvaliables--;
        }


    }
}
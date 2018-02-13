using NetCoreDemo.Entities;
using System;
using System.Collections.Generic;

namespace NetCoreDemo.Services
{
    public class LibraryRepository : ILibraryRepository
    {
        public IEnumerable<Author> GetAuthors()
        {
            throw new NotImplementedException();
        }

        public Author GetAuthor(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAuthors(IEnumerable<Guid> authorIds)
        {
            throw new NotImplementedException();
        }

        public void AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public bool AuthorExists(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooksForAuthor(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public Book GetBookForAuthor(Guid authorId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public void AddBookForAuthor(Guid authorId, Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateBookForAuthor(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}

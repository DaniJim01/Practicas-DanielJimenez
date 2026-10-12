using System.Collections.Generic;
using PAP.DataAccess;
using PAP.Repositories;

namespace PAP.Buisness
{
    public class BookManager
    {
        private readonly BookRepository _repository;

        public BookManager()
        {

            _repository = new BookRepository();
        }

        public IEnumerable<Book> GetAllBooksFromDataModel()
        {
            return _repository.GetAll();
        }
    }

}

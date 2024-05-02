using BookAPI.Dto;

namespace BookAPI.Services
{
    public interface IBookServices
    {

        List<Models.Book> GetAllBooks();
        Models.Book GetStudentById(int id);
        Models.Book AddBook(PostBookDto book);
        Models.Book UpdateBook(PutBookDto bookData, int id);
        void DeleteStudent(int id);

    }
}

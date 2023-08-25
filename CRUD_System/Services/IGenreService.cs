namespace CRUD_System.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAllGenre();
        Task<Genre> GetById(byte Id);
        Task<Genre> Create(Genre Genre);
        Genre Update(Genre Genre);
        Genre Delete(Genre Genre);
        Task<bool> isvalidGenre(byte Id);
    }
}

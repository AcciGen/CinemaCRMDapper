using CinemaCRMDapper.Entities.DTOs;
using CinemaCRMDapper.Models;

namespace CinemaCRMDapper.Pattern.IRepositories
{
    public interface IMovieRepository
    {
        public string CreateMovie(MovieDTO movieDTO);
        public IEnumerable<Movie> GetAllMovies();
        public Movie GetByIdMovie(int id);
        public string DeleteMovie(int id);
        public string UpdateMovie(int id, MovieDTO movieDTO);
    }
}

using CinemaCRMDapper.Entities.DTOs;
using CinemaCRMDapper.Models;

namespace CinemaCRMDapper.Pattern
{
    public class IMovieRepository
    {
        public string CreateMovie(MovieDTO movieDTO);
        public IEnumerable<Movie> GetAllMovies();
        public Movie GetByIdMovie(int id);
        public bool DeleteMovie(int id);
        public Movie UpdateMovie(int id, MovieDTO movieDTO);
    }
}

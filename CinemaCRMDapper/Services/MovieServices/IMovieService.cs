using CinemaCRMDapper.Models;

namespace CinemaCRMDapper.Services.MovieServices
{
    public interface IMovieService
    {
        public Movie GetByIdMovie(int id);
    }
}

using CinemaCRMDapper.Models;

namespace CinemaCRMDapper.Services.MovieServices.IService
{
    public interface IMovieService
    {
        public Movie GetByIdMovie(int id);
    }
}

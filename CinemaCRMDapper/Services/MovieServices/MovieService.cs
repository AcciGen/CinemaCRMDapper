using CinemaCRMDapper.Models;
using CinemaCRMDapper.Pattern.IRepositories;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace CinemaCRMDapper.Services.MovieServices
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepo;
        public MovieService(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }

        public Movie GetByIdMovie(int Id)
        {
            var result = _movieRepo.GetAllMovies().FirstOrDefault(movie => movie.Id == Id);

            return result;
        }
    }
}

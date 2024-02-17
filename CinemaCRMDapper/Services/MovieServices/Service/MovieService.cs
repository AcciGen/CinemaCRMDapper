using CinemaCRMDapper.Models;
using CinemaCRMDapper.Pattern.IRepositories;
using CinemaCRMDapper.Services.MovieServices.IService;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace CinemaCRMDapper.Services.MovieServices.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepo;
        public MovieService(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }

        public Movie GetByIdMovie(int id)
        {
            try
            {
                var result = _movieRepo.GetAllMovies().FirstOrDefault(movie => movie.Id == id);

                return result!;
            }
            catch (Exception ex)
            {
                return new Movie { };
            }
        }
    }
}

﻿using CinemaCRMDapper.Entities.DTOs;
using CinemaCRMDapper.Models;

namespace CinemaCRMDapper.Pattern
{
    public class IMovieRepository
    {
        public string CreateMovie(MovieDTO movieDTO);
        public IEnumerable<Movie> GetAllMovies();
        public Movie GetByIdMovie(int id);
        public string DeleteMovie(int id);
        public string UpdateMovie(int id, MovieDTO movieDTO);
    }
}

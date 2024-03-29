﻿using CinemaCRMDapper.Entities.DTOs;
using CinemaCRMDapper.Models;
using CinemaCRMDapper.Pattern.IRepositories;
using Dapper;
using Npgsql;
using System.Xml.Linq;

namespace CinemaCRMDapper.Pattern.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public IConfiguration _configuration;

        public MovieRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateMovie(MovieDTO movieDTO)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "Insert into movies(title, year, budget, avgRate) values (@title, @year, @budget, @avgRate)";

                    var parameters = new MovieDTO
                    {
                        title = movieDTO.title,
                        year = movieDTO.year,
                        budget = movieDTO.budget,
                        avgRate = movieDTO.avgRate,
                    };

                    connection.Execute(query, parameters);
                }

                return "Insertion success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteMovie(int id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "Delete from movies where id = @id;";

                    var response = connection.Execute(query, new { Id = id });

                    return "Deletion success";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "Select * from movies;";

                var result = connection.Query<Movie>(query);

                return result;
            }
        }

        public string UpdateMovie(int id, MovieDTO movieDTO)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    string query = "Update movies set title = @title, year = @year, budget = @budget, avgRate = @avgRate where id = @id";

                    connection.Execute(query, new
                    {
                        movieDTO.title,
                        movieDTO.year,
                        movieDTO.budget,
                        movieDTO.avgRate,
                        Id = id
                    });

                    return "Updation success";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

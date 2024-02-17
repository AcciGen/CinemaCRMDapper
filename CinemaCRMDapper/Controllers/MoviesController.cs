using CinemaCRMDapper.Entities.DTOs;
using CinemaCRMDapper.Models;
using CinemaCRMDapper.Pattern.IRepositories;
using CinemaCRMDapper.Services.MovieServices.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Reflection;

namespace CinemaCRMDapper.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepo;
        private readonly IMovieService _movieService;

        public MoviesController(IMovieRepository movieRepo, IMovieService movieService)
        {
            _movieRepo = movieRepo;
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            try
            {
                var response = _movieRepo.GetAllMovies();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetById(int Id)
        {
            try
            {
                Movie response = _movieService.GetByIdMovie(Id);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateMovies(MovieDTO model)
        {
            try
            {
                var response = _movieRepo.CreateMovie(model);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var response = _movieRepo.DeleteMovie(id);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(int id, MovieDTO model)
        {
            try
            {
                var response = _movieRepo.UpdateMovie(id, model);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}

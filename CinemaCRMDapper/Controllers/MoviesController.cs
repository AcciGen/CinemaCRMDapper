using CinemaCRMDapper.Entities.DTOs;
using CinemaCRMDapper.Pattern;
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

        public MoviesController(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
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
        public IActionResult GetAllMoviesById(int id)
        {
            try
            {
                var response = _movieRepo.GetByIdMovie(id);

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

using CinemaCRMDapper.Entities.DTOs;
using Dapper;
using Npgsql;
using System.Xml.Linq;

namespace CinemaCRMDapper.Pattern
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
                    string query = "Insert into students(title, year, budget, avgRate) values (@title, @year, @budget, @avgRate)";

                    var parameters = new MovieDTO
                    {
                        title = movieDTO.title,
                        year = movieDTO.year,
                        budget = movieDTO.budget,
                        avgRate = movieDTO.avgRate,
                    };

                    connection.Execute(query, parameters);
                }

                return "Insertion done";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteStudent(int id)
        {

            using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "Delete from movies where id = @id;";

                var response = connection.Execute(query, new { Id = id });

                return true;
            }
        }

        public IEnumerable<Student> GetAllStudents()
        {

            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select * from students";

                var result = connection.Query<Student>(query);

                return result;
            }

        }

        public Student GetByIdStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(int id, StudentDTO studentDTO)
        {
            throw new NotImplementedException();
        }
    }
}

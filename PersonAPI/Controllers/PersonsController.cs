using Microsoft.AspNetCore.Mvc;
using PersonAPI.Application.Interfaces.Persons;
using PersonAPI.Application.UseCases.Persons.AddPersonUseCases;
using PersonAPI.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IAddPersonUseCase _addPersonUseCase;

        public PersonsController(IAddPersonUseCase addPersonUseCase)
        {
            _addPersonUseCase = addPersonUseCase;
        }

        // GET: api/persons
        [HttpGet]
        public ActionResult<List<Person>> GetAllPersons()
        {
            //var persons = _personService.GetAllPersons();
            return Ok();
        }

        // GET: api/persons/{id}
        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            try
            {
                //var person = _personService.GetPersonById(id);
                return Ok();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        // POST: api/persons
        [HttpPost]
        public async Task<IActionResult> AddPerson([FromBody] AddPersonRequest request)
        {
            var newPerson = await _addPersonUseCase.ExecuteAsync(request);
            // Return 201 Created with the resource location
            return Ok(newPerson);
        }

        // PUT: api/persons/{id}
        [HttpPut("{id}")]
        public ActionResult<Person> UpdatePerson(int id, [FromBody] UpdatePersonRequest request)
        {
            try
            {
                // var updatedPerson = _personService.UpdatePerson(id, request);
                return Ok();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        // DELETE: api/persons/{id}
        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            try
            {
                DeletePerson(id);
                return NoContent(); // 204 No Content for successful deletion
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        // POST: api/persons/filter
        [HttpPost("filter")]
        public ActionResult<List<Person>> FilterPersons([FromBody] FilterPersonsRequest request)
        {
            // var filteredPersons = _personService.FilterPersons(request);
            return Ok();
        }
    }
}

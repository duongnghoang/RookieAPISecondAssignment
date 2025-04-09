using Microsoft.AspNetCore.Mvc;
using PersonAPI.Application.Interfaces.Persons;
using PersonAPI.Application.Services.Persons.AddPersonServices;
using PersonAPI.Application.Services.Persons.FilterPersonServices;
using PersonAPI.Application.Services.Persons.UpdatePersonServices;
using PersonAPI.Domain.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonsController : ControllerBase
{
    private readonly IAddPersonService _addPersonService;
    private readonly IDeletePersonService _deletePersonService;
    private readonly IFilterPersonService _filterPersonService;
    private readonly IUpdatePersonService _updatePersonService;

    public PersonsController(IAddPersonService addPersonService, IUpdatePersonService updatePersonService,
        IDeletePersonService deletePersonService, IFilterPersonService filterPersonService)
    {
        _addPersonService = addPersonService;
        _updatePersonService = updatePersonService;
        _deletePersonService = deletePersonService;
        _filterPersonService = filterPersonService;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = (typeof(Result<AddPersonResponse>)))]
    public async Task<IActionResult> AddPerson([FromBody] AddPersonRequest request)
    {
        var result = await _addPersonService.ExecuteAsync(request);
        if (result.IsFailure)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = (typeof(Result<UpdatePersonResponse>)))]
    public async Task<IActionResult> UpdatePerson(Guid id, [FromBody] UpdatePersonRequest request)
    {
        request.Id = id;
        var result = await _updatePersonService.ExecuteAsync(request);
        if (result.IsFailure)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> DeletePerson(Guid id)
    {
        var result = await _deletePersonService.ExecuteAsync(id);
        if (result.IsFailure)
        {
            return BadRequest(result);
        }

        return NoContent();
    }

    [HttpGet("filter")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = (typeof(Result<List<FilterPersonResponse>>)))]
    public async Task<IActionResult> FilterPersons([FromQuery] FilterPersonRequest request)
    {
        var result = await _filterPersonService.ExecuteAsync(request);

        return Ok(result);
    }
}
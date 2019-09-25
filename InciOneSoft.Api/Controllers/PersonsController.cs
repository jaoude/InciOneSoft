using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InciOneSoft.BLL.Dtos;
using InciOneSoft.BLL.Services;
using InciOneSoft.DAL.Repositories;
using InciOneSoft.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InciOneSoft.Api.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly ILogger<PersonsController> _logger;
        private readonly IPersonService _personService;
        public PersonsController(IUnitOfWork unitOfWork, ILogger<PersonsController> logger, IPersonService personService)
        {
            _personService = personService;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> GetPersons(CancellationToken ct)
        {
            _logger.LogInformation("called GetPersons");
            var personsDto = await _personService.GetPersonsAsync(ct);
            return Ok(personsDto);
        }


        [HttpGet]
        [Route("{id}", Name = "GetPerson")]
        public async Task<IActionResult> GetPerson(Guid id, CancellationToken ct)
        {
            _logger.LogInformation("called GetPerson");
            var personDto = await _personService.GetPersonAsync(id, ct);
            return Ok(personDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson([FromBody] CreatePersonDto person, CancellationToken ct)
        {
            _logger.LogInformation("called CreatePerson {0}", person.ToString());
            var id = await _personService.CreatePersonAsync(person, ct);
            if (id == Guid.Empty)
                return UnprocessableEntity();
            else
                return CreatedAtRoute("GetPerson",
                    new { id = id },
                    person);
        }
    }
}


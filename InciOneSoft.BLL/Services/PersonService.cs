using AutoMapper;
using Microsoft.Extensions.Logging;
using InciOneSoft.BLL.Dtos;
using InciOneSoft.DAL.Entities;
using InciOneSoft.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using InciOneSoft.BLL.Helpers;

namespace InciOneSoft.BLL.Services
{
    public class PersonService : ServiceBase, IPersonService
    {
        public PersonService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<PersonService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<IEnumerable<PersonDto>> GetPersonsAsync(CancellationToken ct)
        {
            IEnumerable<Person> personsEntity = await _uow.Persons.GetPersonsAsync(ct);
            IEnumerable<PersonDto> personsDto= _mapper.Mapper.Map<IEnumerable<PersonDto>>(personsEntity);
            return personsDto.ToList();
        }

        public async Task<PersonDto> GetPersonAsync(Guid id, CancellationToken ct)
        {
            Person personsEntity = await _uow.Persons.GetPersonAsync(id, ct);
            PersonDto personsDto = _mapper.Mapper.Map<PersonDto>(personsEntity);
            return personsDto;
        }

        public async Task<Guid> CreatePersonAsync(CreatePersonDto createPersonDto, CancellationToken ct)
        {
            Person personsEntity = _mapper.Mapper.Map<Person>(createPersonDto);
            _uow.Persons.CreatePerson(personsEntity);

            if (await _uow.SaveChangesAsync(ct) > 0)
                return personsEntity.Id;
            else
                return Guid.Empty;
        }
    }
}

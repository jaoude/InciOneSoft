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
    public class FileService : ServiceBase, IFileService
    {
        public FileService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<PersonService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<bool> UploadFileAsync(CancellationToken ct)
        {
            return false;
            //IEnumerable<Person> personsEntity = await _uow.Persons.GetPersonsAsync(ct);
            //IEnumerable<PersonDto> personsDto= _mapper.Mapper.Map<IEnumerable<PersonDto>>(personsEntity);
            //return personsDto.ToList();
        }
    }
}

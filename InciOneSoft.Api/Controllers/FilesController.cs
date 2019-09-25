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
using System.Net;
using InciOneSoft.BLL.Dtos.Request;

namespace InciOneSoft.Api.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly ILogger<PersonsController> _logger;
        private readonly IFileService _fileService;
        public FilesController(IUnitOfWork unitOfWork, ILogger<PersonsController> logger, IFileService fileService)
        {
            _fileService = fileService;
            _logger = logger;
        }

        [HttpPost("UploadFile")]
        public async Task<IActionResult> Post([FromBody] UploadFileDto file)
        {
            //long size = files.Sum(f => f.Length);

            //// full path to file in temp location
            //var filePath = Path.GetTempFileName();

            //foreach (var formFile in files)
            //{
            //    if (formFile.Length > 0)
            //    {
            //        using (var stream = new FileStream(filePath, FileMode.Create))
            //        {
            //            await formFile.CopyToAsync(stream);
            //        }
            //    }
            //}
            return Ok();
            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

        //    return Ok(new { count = files.Count, size, filePath });
        }
        [HttpPost]
        public async Task<IActionResult> Upload(CancellationToken ct)
        {
            _logger.LogInformation("called GetPersons");
            var personsDto = await _fileService.UploadFileAsync(ct);
            return Ok();
        }
    }
}


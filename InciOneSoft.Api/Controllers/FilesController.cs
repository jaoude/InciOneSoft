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
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Text;
using Newtonsoft.Json;
using System.Security.Claims;

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
        public async Task<IActionResult> Post(IFormFile file, [FromForm]string fileInfoText, CancellationToken ct)
        {
            byte[] fileBytesArray = null;
            
            using (var fileMemoryStream = new MemoryStream())
            {
                file.CopyTo(fileMemoryStream);
                fileBytesArray = fileMemoryStream.ToArray();
            }
            
            await _fileService.UploadFileAsync (
                JsonConvert.DeserializeObject<FileInfoDto>(fileInfoText), 
                fileBytesArray, 
                User?.Identity?.Name, 
                ct);
            
            return Ok(new { count = 1, file.Length });
        }
    }
}


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
using Microsoft.VisualBasic.FileIO;
using System.IO;
using InciOneSoft.BLL.Dtos.Request;
using FileInfo = InciOneSoft.DAL.Entities.FileInfo;

namespace InciOneSoft.BLL.Services
{
    public class FileService : ServiceBase, IFileService
    {
        public FileService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<PersonService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<bool> UploadFileAsync(FileInfoDto fileInfoDto, byte[] fileBytesArray, string userName, CancellationToken ct)
        {
            FileInfo fileInfoEnity = _mapper.Mapper.Map<FileInfo>(fileInfoDto);

            _uow.FileInfos.Add(fileInfoEnity);

            using (TextFieldParser parser = new TextFieldParser(new MemoryStream(fileBytesArray)))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {

                    }
                }
            }
            // 422 Unprocessable Entity
            return false;
        }
    }
}

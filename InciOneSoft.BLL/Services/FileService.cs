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

namespace InciOneSoft.BLL.Services
{
    public class FileService : ServiceBase, IFileService
    {
        public FileService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<PersonService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<bool> UploadFileAsync(byte[] fileBytesArray, CancellationToken ct)
        {
            using (TextFieldParser parser = new TextFieldParser(new MemoryStream(fileBytesArray)))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        //TODO: Process field
                    }
                }
            }

            return false;
        }
    }
}

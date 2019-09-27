using InciOneSoft.BLL.Dtos;
using InciOneSoft.BLL.Dtos.Request;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InciOneSoft.BLL.Services
{
    public interface IFileService : IServiceBase
    {
        Task<bool> UploadFileAsync(FileInfoDto fileInfoDto, byte[] fileBytesArray, string userName, CancellationToken ct);
    }
}

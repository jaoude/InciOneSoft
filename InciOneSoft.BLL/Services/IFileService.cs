using InciOneSoft.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InciOneSoft.BLL.Services
{
    public interface IFileService : IServiceBase
    {
        Task<bool> UploadFileAsync(byte[] fileBytesArray, CancellationToken ct);
    }
}

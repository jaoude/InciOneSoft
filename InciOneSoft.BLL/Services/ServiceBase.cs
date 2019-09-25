using AutoMapper;
using Microsoft.Extensions.Logging;
using InciOneSoft.BLL.Helpers;
using InciOneSoft.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace InciOneSoft.BLL.Services
{
    public class ServiceBase : IServiceBase 
    {
        protected readonly IUnitOfWork _uow;
        protected readonly IAutoMapperService _mapper;
        protected readonly ILogger<ServiceBase> _logger;

        public ServiceBase(IUnitOfWork uow, IAutoMapperService mapper, ILogger<ServiceBase> logger)
        {
            _uow = uow;
            _mapper = mapper;
            _logger = logger;
        }
    }
}

﻿using AutoMapper;
using CompanyWebApi.Domains.Models;
using CompanyWebApi.Resources;

namespace CompanyWebApi.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Company, CompanyResource>();
            CreateMap<Employee, EmployeeResource>();
        }
    }
}

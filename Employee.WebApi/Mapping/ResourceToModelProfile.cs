using CompanyWebApi.Domains.Models;
using CompanyWebApi.Resources;

namespace CompanyWebApi.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveEmployeeResource, Employee>();
        }
    }
}

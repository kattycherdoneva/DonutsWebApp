using AutoMapper;

namespace DonutsWebApp.Services.Mapping.Interfaces
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression configuration);
    }
}

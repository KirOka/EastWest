using AutoMapper;
using EastWest.Mapping;
using System.Data;

namespace EastWest
{
    public class MapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<BusinessLogic.Services.Implementations.Mapping.OrderMappingsProfile>();
                cfg.AddProfile< BusinessLogic.Services.Implementations.Mapping.PositionMappingsProfile> ();

                cfg.AddProfile<EastWest.Mapping.OrderMappingsProfile>();
                cfg.AddProfile<EastWest.Mapping.PositionMappingsProfile>();

                cfg.AddProfile<EastWest.Mapping.OrderViewMappingsProfile>();
                cfg.AddProfile<EastWest.Mapping.PositionViewMappingsProfile>();
            });
            try
            {
                configuration.AssertConfigurationIsValid();
            }
            catch (Exception ex)
            {
                throw new Exception("AssertConfiguration err", ex);
            }
            return configuration;
        }
    }
}

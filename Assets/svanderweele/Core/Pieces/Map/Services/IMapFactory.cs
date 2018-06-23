using svanderweele.Core.Pieces.Map.Data;

namespace svanderweele.Core.Pieces.Map.Services
{
    public interface IMapFactory
    {
        void CreateMap(MapCreationData mapCreationData);
    }
}
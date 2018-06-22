
using Entitas;

namespace svanderweele.Mine.Core.Services.View
{
    public interface IViewService
    {
        void LoadAsset(Contexts contexts, IEntity entity, string assetName);
        void LinkAsset(Contexts contexts, IEntity entity, IViewController controller);
    }

}
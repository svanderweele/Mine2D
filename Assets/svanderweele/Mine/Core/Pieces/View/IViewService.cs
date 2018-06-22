
using Entitas;
using svanderweele.Mine.Core.Services.View;

namespace svanderweele.Mine.Core.Pieces.View
{
    public interface IViewService
    {
        void LoadAsset(Contexts contexts, IEntity entity, string assetPath);
        void LinkAsset(Contexts contexts, IEntity entity, IViewController controller);
    }

}
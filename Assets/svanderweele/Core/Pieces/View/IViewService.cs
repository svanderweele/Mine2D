using Entitas;

namespace svanderweele.Core.Pieces.View
{
    public interface IViewService
    {
        void LoadAsset(Contexts contexts, IEntity entity, string assetPath);
        void LinkAsset(Contexts contexts, IEntity entity, IViewController controller);
    }

}
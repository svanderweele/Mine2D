using Entitas;

namespace svanderweele.Mine.Core.Services.Selection
{
    public interface ISelectionController
    {
        void Initialize(Contexts contexts, IEntity entity);
    }
}
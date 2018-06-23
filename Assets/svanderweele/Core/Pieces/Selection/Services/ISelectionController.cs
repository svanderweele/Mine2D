using Entitas;

namespace svanderweele.Core.Pieces.Selection.Services
{
    public interface ISelectionController
    {
        void Initialize(Contexts contexts, IEntity entity);
    }
}
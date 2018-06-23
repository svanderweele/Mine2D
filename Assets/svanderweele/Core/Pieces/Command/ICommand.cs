using Entitas;

namespace svanderweele.Core.Pieces.Command
{
    public interface ICommand
    {
        bool IsForced { get; set; }
        void DoCommand(bool forced = false);
        void UndoCommand(bool forced = false);
    }

}
using Entitas;
using Entitas.CodeGeneration.Attributes;

[Meta, Unique]
public class ViewServiceComponent : IComponent {
    public IViewService instance;
}
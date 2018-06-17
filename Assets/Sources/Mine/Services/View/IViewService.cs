
using Entitas;
using Entitas.CodeGeneration.Attributes;

public interface IViewService
{
    void LoadAsset(Contexts contexts, IEntity entity, string assetName);    
}
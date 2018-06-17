

using Entitas;

public class RegisterViewServiceSystem : IInitializeSystem
{

    private MetaContext _metaContext;
    private IViewService _viewService;

    public RegisterViewServiceSystem(Contexts contexts, IViewService viewService)
    {
        _metaContext = contexts.meta;
        _viewService = viewService;
    }

    public void Initialize()
    {
        _metaContext.ReplaceViewService(_viewService);
    }
}
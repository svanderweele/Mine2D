

public class RegisterServicesSystem : Feature
{
    public RegisterServicesSystem(Contexts contexts, Services services)
    {
        Add(new RegisterViewServiceSystem(contexts, services.View));
    }
}
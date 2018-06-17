public class Services
{

    public readonly IViewService View;
    public readonly IInputService Input;

    public Services(IViewService view, IInputService input){
        View = view;
        Input = input;
    }
}
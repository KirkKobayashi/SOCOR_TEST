
namespace TruckScale.UI.HelperClass
{
    public interface IUIFactory
    {
        T CreateForm<T>() where T : Form;
        T CreateUC<T>() where T : UserControl;
    }
}
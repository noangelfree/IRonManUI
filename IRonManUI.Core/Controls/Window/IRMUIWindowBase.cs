using System.Windows;

namespace IRonManUI.Core.Controls.Window
{
    public class IRMUIWindowBase : System.Windows.Window
    {
       public IRMUIWindowBase()
        {
            this.Style = (Style)FindResource("IRMUIWindowStyle");
        }
    }
}

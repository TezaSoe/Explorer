using System.Drawing;
using System.Windows.Forms;

namespace Explorer.Extensions
{
    public static class ControlExtensions
    {
        public static Rectangle ScreenRectangle(this Control control)
        {
            return control.RectangleToScreen(control.ClientRectangle);
        }
    }
}

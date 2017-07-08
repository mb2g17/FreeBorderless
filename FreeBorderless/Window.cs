using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeBorderless
{
    public class Window
    {
        public Window()
        {
            title = "";
            originalSize = new Rectangle(0, 0, 0, 0);
        }

        public string title;
        public IntPtr handle;
        public IntPtr menu;
        public long oldStyle;
        public Rectangle originalSize;
    }
}

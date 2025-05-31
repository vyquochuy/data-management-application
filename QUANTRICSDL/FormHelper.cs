using System;
using System.Drawing;
using System.Windows.Forms;

namespace QUANTRICSDL
{
    public static class FormHelper
    {
        public static void SetStandardSize(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            //form.StartPosition = FormStartPosition.Manual; // Cho phép tự đặt vị trí
            
            //form.Size = new Size(800, 450); // Cỡ cố định
            form.Size = new Size(1280, 720); // HD 720p
            
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Engine
    {
        int i = 0;
        Random random = new Random();
        
        public void Counter(Label label)
        {
            i++;
            label.Text = i.ToString();
        }
        public void ColorChanger(Form form)
        {
            if (i % 2 == 0)
            {
               form.BackColor = Color.Blue;
            }
            else form.BackColor = Color.Red;
            if (i % 3 == 0)
            {
                form.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            }
        }
    }
}

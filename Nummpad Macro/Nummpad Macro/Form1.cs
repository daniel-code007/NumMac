using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Nummpad_Macro
{
    public partial class NumMacPad : Form
    {
        public NumMacPad()
        {
            InitializeComponent();
        }  

        private void NumPad1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    Macro1.PerformClick();
                    break;     

            }
        }

        private void NumPad2(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad2:
                    Macro2.PerformClick();
                    break;

            }
        }

        private void NumPad3(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad3:
                    Macro3.PerformClick();
                    break;

            }
        }

        private void NumPad4(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad4:
                    Macro4.PerformClick();
                    break;

            }
        }

        private void NumPad5(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad5:
                    Macro5.PerformClick();
                    break;

            }
        }

        private void NumPad6(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad6:
                    Macro6.PerformClick();
                    break;

            }

        }


        private void NumPad7(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad7:
                    Macro7.PerformClick();
                    break;

            }
        }

        private void NumPad8(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad8:
                    Macro8.PerformClick();
                    break;

            }
        }

        private void NumPad9(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad9:
                    Macro9.PerformClick();
                    break;

            }
        }

        private void Recorder_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}

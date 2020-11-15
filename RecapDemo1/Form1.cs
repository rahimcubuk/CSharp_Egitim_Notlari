using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButton();
        }

        private void GenerateButton()
        {
            int top = 0, left = 0;
            Button[,] buttons = new Button[8, 8];
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= buttons.GetUpperBound(1); k++)
                {
                    buttons[i, k] = new Button();
                    buttons[i, k].Width = 50;
                    buttons[i, k].Height = 50;
                    buttons[i, k].Top = top;
                    buttons[i, k].Left = left;
                    left += 50;
                    buttons[i, k].BackColor = ((i + k) % 2 == 0 ? Color.Black : Color.White);
                    this.Controls.Add(buttons[i, k]);
                }
                left = 0;
                top += 50;
            }
        }
    }
}

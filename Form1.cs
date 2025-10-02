using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fixedMoveAndResizeForm ()
        {
            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2; 
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);

            this.Size = new Size(1239, 733);
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormTO_DO_List frmTO_DO_List = new FormTO_DO_List();
            frmTO_DO_List.ShowDialog(); 

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            fixedMoveAndResizeForm();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            fixedMoveAndResizeForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

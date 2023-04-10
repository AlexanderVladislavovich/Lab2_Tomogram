using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using Bin_Class;
using View_Class;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        Bin file;
        bool loaded = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                Bin.readBIN(str);
                view.SetupView(Width, Height);
             
                loaded = true;
                
            }
        }
    }
}

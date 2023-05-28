using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkCodeAdder
{
    public partial class Main : Form
    {
        JunkAdder junk;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void siticoneRoundedTextBox1_Enter(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users\\krzyc\\OneDrive\\Pulpit\\Example";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                junk = new JunkAdder(dialog.FileName);
                siticoneRoundedTextBox1.Text = dialog.FileName;
            }
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if(junk == null) { MessageBox.Show("Specify location first"); return; }
            junk.options[0] = EveryDirSwitch.Checked;
            try{
                junk.files = new int[] { (int)MainNum.Value, (int)EveryLocNum.Value };
            }
            catch
            {
                MessageBox.Show("Number of files must be specified as INT (normal number ex. 1,7)");
                Environment.Exit(120);
            }
            
            junk.AddJunkCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using net.sf.mpxj;
using net.sf.mpxj.reader;
using net.sf.mpxj.writer;
using net.sf.mpxj.mpp;
using net.sf.mpxj.ikvm;
using ConvertionApp;

using java.io;
using net.sf.mpxj.mspdi;

namespace ConvertionApp
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
            completelbl.Visible = false;
        }
        OpenFileDialog open = new OpenFileDialog();
        ProjectReader reader = new MPPReader();
        string fileNewLocation;
        string fileNewName;
        private void chooseBtn_Click(object sender, EventArgs e)
        {
            open.Filter = "MPP|*.mpp";
            if (open.ShowDialog() == DialogResult.OK)
            {
               fileLocation.Text = open.FileName;
                fileName.Text = open.SafeFileName;
            }
        }

        private void convertFile_Click(object sender, EventArgs e)
        {
            fileNewName = fileName.Text;
            fileNewName = fileNewName.Replace(".mpp", ".xml");
            fileNewLocation = fileLocation.Text;
            fileNewLocation = fileNewLocation.Replace(fileName.Text, "");
            System.Console.WriteLine(fileNewLocation + fileNewName);
            UniversalProjectReader reader = new UniversalProjectReader();
            ProjectFile project = reader.read(fileLocation.Text);
            System.Console.WriteLine(fileLocation.Text);
            ProjectWriter writer = new MSPDIWriter();
            writer.write(project, @"C:\Users\GOCG\Desktop\" + fileNewName);
            System.Console.WriteLine("Process completed");
            completelbl.Visible = true;





        }
    }
}

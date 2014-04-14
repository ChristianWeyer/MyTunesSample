using System;
using System.Windows.Forms;
using MyTunes.BusinessLogic;
using MyTunes.BusinessLogic.Interfaces;

namespace MyTunes.WindowsClient
{
    public partial class Form1 : Form
    {
        private ITracksManager tracksManager;

        public Form1()
        {
            tracksManager = new TracksManager();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = tracksManager.ListTracks();
        }
    }
}

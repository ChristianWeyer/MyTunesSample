using System;
using System.Windows.Forms;

namespace MyTunes.WindowsClient
{
    public partial class Form1 : Form
    {
        private LocalTracksManager tracksManager;

        public Form1()
        {
            tracksManager = new LocalTracksManager();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tracks = tracksManager.LoadTracks();

            listBox1.DisplayMember = "Name";
            listBox1.DataSource = tracks;
        }
    }
}

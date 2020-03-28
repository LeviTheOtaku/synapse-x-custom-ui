using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;

namespace Synapse_X_Custom_UI_Template
{
    public partial class Form1 : Form
    {
        public SxLibWinForms sxlib;
        public Form1()
        {
            if (Properties.Settings.Default.synapsedir == "")
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sxlib = SxLib.InitializeWinForms(this, Properties.Settings.Default.synapsedir);
            sxlib.AttachEvent += Sxlib_AttachEvent;
            sxlib.LoadEvent += Sxlib_LoadEvent;
            sxlib.ScriptHubEvent += Sxlib_ScriptHubEvent;
            sxlib.Load();
        }

        private void Sxlib_ScriptHubEvent(List<SxLibBase.SynHubEntry> Entries)
        {
            WebClient client = new WebClient();
            foreach (var Entry in Entries)
            {
                Stream stream = client.OpenRead(Entry.Picture);
                PictureBox pb = new PictureBox();
                pb.Image = new Bitmap(stream);
                pb.SizeMode = PictureBoxSizeMode.AutoSize;
                scriptHubPanel.Controls.Add(pb, 0, 0);
                pb.MouseHover += Pb_MouseHover;

                void Pb_MouseHover(object sender, EventArgs e)
                {
                    SHtitleLabel.Text = Entry.Name;
                    SHdescLabel.Text = Entry.Description;
                }

                pb.MouseClick += Pb_MouseClick;
                void Pb_MouseClick(object sender, EventArgs e)
                {
                    Entry.Execute();
                }
            }
        }


        private void Sxlib_LoadEvent(SxLibBase.SynLoadEvents Event, object Param)
        {
            statusLabel.Text = "Presetup: " + Event.ToString().Replace("_", " ").ToLower().First().ToString().ToUpper() + Event.ToString().Replace("_", " ").ToLower().Substring(1) + ".";
            if (Event == SxLibBase.SynLoadEvents.READY)
            {
                sxlib.ScriptHub();
            }
        }

        private void Sxlib_AttachEvent(SxLibBase.SynAttachEvents Event, object Param)
        {
            statusLabel.Text = "Injection: " + Event.ToString().Replace("_", " ").ToLower().First().ToString().ToUpper() + Event.ToString().Replace("_", " ").ToLower().Substring(1) + ".";
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            sxlib.Attach();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            sxlib.Execute(richTextBox1.Text);
        }

        private void changeSynapseDirButton_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.synapsedir = "";
            Properties.Settings.Default.Save();
            MessageBox.Show("Please relaunch Synapse X Custom UI Template to reset your Synapse X directory now!");
            System.Environment.Exit(0);
        }
    }

}
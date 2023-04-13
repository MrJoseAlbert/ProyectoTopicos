using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoU1P2
{
    public partial class Acercade : Form
    {
        public Acercade()
        {
            InitializeComponent();
        }


        private void llinklcvjaProovedores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llinklcvjaProovedores.LinkVisited = true;
            Process.Start("MicrosoftEdge", "ddtech.mx");
        }

        private void linklcvjaYoutube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklcvjaYoutube.LinkVisited = true;
            Process.Start("MicrosoftEdge", "youtube.com");
        }

        private void linklcvjaFace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklcvjaFace.LinkVisited = true;
            Process.Start("MicrosoftEdge", "facebook.com");
        }
    }
}

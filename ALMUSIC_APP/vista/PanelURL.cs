using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALMUSIC_APP.vista
{
    public partial class PanelURL : Form
    {
        private Program program;
        public PanelURL(Program program)
        {
            this.program = program;
            InitializeComponent();
        }

        private void PanelURL_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            abrirURL();
        }

        private void abrirURL()
        {
            if (validar()) {

            }
        }

        private bool validar()
        {
            if (textBoxURL.Text.Equals(""))
            {
                return false;
            }
            else {
                string url = textBoxURL.Text;

                return this.program.reproducirStreaming(url);        
            }
        }
    }
}

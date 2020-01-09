using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiIndiceAcademico_F1
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void C_ID_comboBox_TextChanged(object sender, EventArgs e)
        {
            C_dataGrid.Refresh();
        }
    }
}

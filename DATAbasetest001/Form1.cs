using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATAbasetest001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_A3E7DC_db1DataSet3.Faculties' table. You can move, or remove it, as needed.
            this.facultiesTableAdapter1.Fill(this.dB_A3E7DC_db1DataSet3.Faculties);
            // TODO: This line of code loads data into the 'dB_A3E7DC_db1DataSet2.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.dB_A3E7DC_db1DataSet2.Groups);
            // TODO: This line of code loads data into the 'dB_A3E7DC_db1DataSet.Faculties' table. You can move, or remove it, as needed.
            this.facultiesTableAdapter.Fill(this.dB_A3E7DC_db1DataSet.Faculties);

        }
    }
}

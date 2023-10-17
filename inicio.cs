using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FantasticFeedback__FF_
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 f1 = new form1(); 
            f1.Show();  
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            this.juegosTableAdapter.Fill(this.fFDataSet.Juegos);

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.juegosBindingSource.Filter = this.advancedDataGridView1.FilterString;  
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.juegosBindingSource.Sort = this.advancedDataGridView1.SortString;  
        }

        private void juegosBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            label1.Text = string.Format("Total de juegos: {0}", this.juegosBindingSource.List.Count);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reviews r = new Reviews();
            r.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios u = new Usuarios();    
            u.Show();
        }
    }
}

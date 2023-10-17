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
    public partial class Reviews : Form
    {
        public Reviews()
        {
            InitializeComponent();
        }

        private void Reviews_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fFDataSet2.Reviews' Puede moverla o quitarla según sea necesario.
            this.reviewsTableAdapter.Fill(this.fFDataSet2.Reviews);

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio i = new inicio();
            i.Show();
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.reviewsBindingSource.Sort = this.advancedDataGridView1.SortString;
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.reviewsBindingSource.Filter = this.advancedDataGridView1.FilterString; 
        }

        private void reviewsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            label1.Text = string.Format("Total de reviews: {0}", this.reviewsBindingSource.List.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio i = new inicio();
            i.Show();
        }
    }
}

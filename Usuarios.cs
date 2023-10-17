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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fFDataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.fFDataSet1.Usuarios);

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.usuariosBindingSource.Filter = this.advancedDataGridView1.FilterString;    
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.usuariosBindingSource.Sort = this.advancedDataGridView1.SortString;        
        }

        private void usuariosBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            label1.Text = string.Format("Total de usuarios: {0}", this.usuariosBindingSource.List.Count);   
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio i = new inicio();    
            i.Show();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio i = new inicio();
            i.Show();
        }
    }
}

namespace FantasticFeedback__FF_
{
    partial class inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.fFDataSet = new FantasticFeedback__FF_.FFDataSet();
            this.juegosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juegosTableAdapter = new FantasticFeedback__FF_.FFDataSetTableAdapters.JuegosTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.iDJuegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.títuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoContenidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataformaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(861, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 49;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fFDataSet
            // 
            this.fFDataSet.DataSetName = "FFDataSet";
            this.fFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // juegosBindingSource
            // 
            this.juegosBindingSource.DataMember = "Juegos";
            this.juegosBindingSource.DataSource = this.fFDataSet;
            this.juegosBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.juegosBindingSource_ListChanged);
            // 
            // juegosTableAdapter
            // 
            this.juegosTableAdapter.ClearBeforeFill = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AllowUserToResizeColumns = false;
            this.advancedDataGridView1.AllowUserToResizeRows = false;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.advancedDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDJuegoDataGridViewTextBoxColumn,
            this.títuloDataGridViewTextBoxColumn,
            this.tipoContenidoDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.plataformaDataGridViewTextBoxColumn,
            this.developerDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.juegosBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.advancedDataGridView1.Location = new System.Drawing.Point(24, 69);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.Size = new System.Drawing.Size(855, 175);
            this.advancedDataGridView1.TabIndex = 50;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // iDJuegoDataGridViewTextBoxColumn
            // 
            this.iDJuegoDataGridViewTextBoxColumn.DataPropertyName = "ID_Juego";
            this.iDJuegoDataGridViewTextBoxColumn.HeaderText = "ID_Juego";
            this.iDJuegoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDJuegoDataGridViewTextBoxColumn.Name = "iDJuegoDataGridViewTextBoxColumn";
            this.iDJuegoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDJuegoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iDJuegoDataGridViewTextBoxColumn.Width = 78;
            // 
            // títuloDataGridViewTextBoxColumn
            // 
            this.títuloDataGridViewTextBoxColumn.DataPropertyName = "Título";
            this.títuloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.títuloDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.títuloDataGridViewTextBoxColumn.Name = "títuloDataGridViewTextBoxColumn";
            this.títuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.títuloDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.títuloDataGridViewTextBoxColumn.Width = 60;
            // 
            // tipoContenidoDataGridViewTextBoxColumn
            // 
            this.tipoContenidoDataGridViewTextBoxColumn.DataPropertyName = "TipoContenido";
            this.tipoContenidoDataGridViewTextBoxColumn.HeaderText = "TipoContenido";
            this.tipoContenidoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tipoContenidoDataGridViewTextBoxColumn.Name = "tipoContenidoDataGridViewTextBoxColumn";
            this.tipoContenidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoContenidoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tipoContenidoDataGridViewTextBoxColumn.Width = 101;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "releaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "releaseDate";
            this.releaseDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.releaseDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.releaseDateDataGridViewTextBoxColumn.Width = 89;
            // 
            // plataformaDataGridViewTextBoxColumn
            // 
            this.plataformaDataGridViewTextBoxColumn.DataPropertyName = "Plataforma";
            this.plataformaDataGridViewTextBoxColumn.HeaderText = "Plataforma";
            this.plataformaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.plataformaDataGridViewTextBoxColumn.Name = "plataformaDataGridViewTextBoxColumn";
            this.plataformaDataGridViewTextBoxColumn.ReadOnly = true;
            this.plataformaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.plataformaDataGridViewTextBoxColumn.Width = 82;
            // 
            // developerDataGridViewTextBoxColumn
            // 
            this.developerDataGridViewTextBoxColumn.DataPropertyName = "Developer";
            this.developerDataGridViewTextBoxColumn.HeaderText = "Developer";
            this.developerDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.developerDataGridViewTextBoxColumn.Name = "developerDataGridViewTextBoxColumn";
            this.developerDataGridViewTextBoxColumn.ReadOnly = true;
            this.developerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.developerDataGridViewTextBoxColumn.Width = 81;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            this.publisherDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.publisherDataGridViewTextBoxColumn.Width = 75;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.scoreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.scoreDataGridViewTextBoxColumn.Width = 60;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Seleccionar Juego";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Leelawadee", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(745, 294);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(134, 44);
            this.bunifuFlatButton1.TabIndex = 51;
            this.bunifuFlatButton1.Text = "Seleccionar Juego";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Ver usuarios";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Leelawadee", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(15, 294);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(134, 44);
            this.bunifuFlatButton2.TabIndex = 51;
            this.bunifuFlatButton2.Text = "Ver usuarios";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(736, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Filas Totales: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(390, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "JUEGOS";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(891, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FFDataSet fFDataSet;
        private System.Windows.Forms.BindingSource juegosBindingSource;
        private FFDataSetTableAdapters.JuegosTableAdapter juegosTableAdapter;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJuegoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn títuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoContenidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataformaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn developerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
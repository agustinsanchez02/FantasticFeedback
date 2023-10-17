namespace FantasticFeedback__FF_
{
    partial class Reviews
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.fFDataSet2 = new FantasticFeedback__FF_.FFDataSet2();
            this.reviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewsTableAdapter = new FantasticFeedback__FF_.FFDataSet2TableAdapters.ReviewsTableAdapter();
            this.iDReviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDJuegoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(312, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "REVIEWS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(598, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Filas Totales: 0";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Volver";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(22, 301);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(134, 44);
            this.bunifuFlatButton2.TabIndex = 61;
            this.bunifuFlatButton2.Text = "Volver";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
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
            this.iDReviewDataGridViewTextBoxColumn,
            this.iDUsuarioDataGridViewTextBoxColumn,
            this.iDJuegoDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.fechaPublicaciónDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.reviewsBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.advancedDataGridView1.Location = new System.Drawing.Point(22, 74);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.Size = new System.Drawing.Size(715, 175);
            this.advancedDataGridView1.TabIndex = 60;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(46)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(719, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 59;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fFDataSet2
            // 
            this.fFDataSet2.DataSetName = "FFDataSet2";
            this.fFDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewsBindingSource
            // 
            this.reviewsBindingSource.DataMember = "Reviews";
            this.reviewsBindingSource.DataSource = this.fFDataSet2;
            this.reviewsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.reviewsBindingSource_ListChanged);
            // 
            // reviewsTableAdapter
            // 
            this.reviewsTableAdapter.ClearBeforeFill = true;
            // 
            // iDReviewDataGridViewTextBoxColumn
            // 
            this.iDReviewDataGridViewTextBoxColumn.DataPropertyName = "ID_Review";
            this.iDReviewDataGridViewTextBoxColumn.HeaderText = "ID_Review";
            this.iDReviewDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDReviewDataGridViewTextBoxColumn.Name = "iDReviewDataGridViewTextBoxColumn";
            this.iDReviewDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDReviewDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iDReviewDataGridViewTextBoxColumn.Width = 85;
            // 
            // iDUsuarioDataGridViewTextBoxColumn
            // 
            this.iDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDUsuarioDataGridViewTextBoxColumn.Name = "iDUsuarioDataGridViewTextBoxColumn";
            this.iDUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUsuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iDUsuarioDataGridViewTextBoxColumn.Width = 68;
            // 
            // iDJuegoDataGridViewTextBoxColumn
            // 
            this.iDJuegoDataGridViewTextBoxColumn.DataPropertyName = "ID_Juego";
            this.iDJuegoDataGridViewTextBoxColumn.HeaderText = "Juego";
            this.iDJuegoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.iDJuegoDataGridViewTextBoxColumn.Name = "iDJuegoDataGridViewTextBoxColumn";
            this.iDJuegoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDJuegoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iDJuegoDataGridViewTextBoxColumn.Width = 61;
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
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.comentarioDataGridViewTextBoxColumn.Width = 85;
            // 
            // fechaPublicaciónDataGridViewTextBoxColumn
            // 
            this.fechaPublicaciónDataGridViewTextBoxColumn.DataPropertyName = "fechaPublicación";
            this.fechaPublicaciónDataGridViewTextBoxColumn.HeaderText = "Fecha de publicación";
            this.fechaPublicaciónDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaPublicaciónDataGridViewTextBoxColumn.Name = "fechaPublicaciónDataGridViewTextBoxColumn";
            this.fechaPublicaciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaPublicaciónDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fechaPublicaciónDataGridViewTextBoxColumn.Width = 123;
            // 
            // Reviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(749, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reviews";
            this.Load += new System.EventHandler(this.Reviews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Button button1;
        private FFDataSet2 fFDataSet2;
        private System.Windows.Forms.BindingSource reviewsBindingSource;
        private FFDataSet2TableAdapters.ReviewsTableAdapter reviewsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDReviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJuegoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicaciónDataGridViewTextBoxColumn;
    }
}
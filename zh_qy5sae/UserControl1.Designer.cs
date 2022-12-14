namespace zh_qy5sae
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxKereso = new System.Windows.Forms.TextBox();
            this.listBoxFogasok = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKereso
            // 
            this.textBoxKereso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKereso.Location = new System.Drawing.Point(36, 86);
            this.textBoxKereso.Name = "textBoxKereso";
            this.textBoxKereso.Size = new System.Drawing.Size(175, 23);
            this.textBoxKereso.TabIndex = 0;
            this.textBoxKereso.TextChanged += new System.EventHandler(this.textBoxKereso_TextChanged);
            // 
            // listBoxFogasok
            // 
            this.listBoxFogasok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFogasok.FormattingEnabled = true;
            this.listBoxFogasok.ItemHeight = 15;
            this.listBoxFogasok.Location = new System.Drawing.Point(36, 125);
            this.listBoxFogasok.Name = "listBoxFogasok";
            this.listBoxFogasok.Size = new System.Drawing.Size(216, 334);
            this.listBoxFogasok.TabIndex = 1;
            this.listBoxFogasok.SelectedIndexChanged += new System.EventHandler(this.listBoxFogasok_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptIdDataGridViewTextBoxColumn,
            this.fogasIdDataGridViewTextBoxColumn,
            this.nyersanyagIdDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.fogasDataGridViewTextBoxColumn,
            this.nyersanyagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.receptekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(326, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(417, 334);
            this.dataGridView1.TabIndex = 2;
            // 
            // receptIdDataGridViewTextBoxColumn
            // 
            this.receptIdDataGridViewTextBoxColumn.DataPropertyName = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.HeaderText = "ReceptId";
            this.receptIdDataGridViewTextBoxColumn.Name = "receptIdDataGridViewTextBoxColumn";
            // 
            // fogasIdDataGridViewTextBoxColumn
            // 
            this.fogasIdDataGridViewTextBoxColumn.DataPropertyName = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.HeaderText = "FogasId";
            this.fogasIdDataGridViewTextBoxColumn.Name = "fogasIdDataGridViewTextBoxColumn";
            // 
            // nyersanyagIdDataGridViewTextBoxColumn
            // 
            this.nyersanyagIdDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.HeaderText = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.Name = "nyersanyagIdDataGridViewTextBoxColumn";
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // fogasDataGridViewTextBoxColumn
            // 
            this.fogasDataGridViewTextBoxColumn.DataPropertyName = "Fogas";
            this.fogasDataGridViewTextBoxColumn.HeaderText = "Fogas";
            this.fogasDataGridViewTextBoxColumn.Name = "fogasDataGridViewTextBoxColumn";
            // 
            // nyersanyagDataGridViewTextBoxColumn
            // 
            this.nyersanyagDataGridViewTextBoxColumn.DataPropertyName = "Nyersanyag";
            this.nyersanyagDataGridViewTextBoxColumn.HeaderText = "Nyersanyag";
            this.nyersanyagDataGridViewTextBoxColumn.Name = "nyersanyagDataGridViewTextBoxColumn";
            // 
            // receptekBindingSource
            // 
            this.receptekBindingSource.DataSource = typeof(zh_qy5sae.Models.Receptek);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxFogasok);
            this.Controls.Add(this.textBoxKereso);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(787, 541);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxKereso;
        private ListBox listBoxFogasok;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn receptIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagDataGridViewTextBoxColumn;
        private BindingSource receptekBindingSource;
    }
}

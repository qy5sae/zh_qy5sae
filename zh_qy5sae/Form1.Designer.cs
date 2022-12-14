namespace zh_qy5sae
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFogasview = new System.Windows.Forms.Button();
            this.buttonHozzavalo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(213, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 517);
            this.panel1.TabIndex = 0;
            // 
            // buttonFogasview
            // 
            this.buttonFogasview.Location = new System.Drawing.Point(29, 48);
            this.buttonFogasview.Name = "buttonFogasview";
            this.buttonFogasview.Size = new System.Drawing.Size(122, 23);
            this.buttonFogasview.TabIndex = 1;
            this.buttonFogasview.Text = "Fogások";
            this.buttonFogasview.UseVisualStyleBackColor = true;
            this.buttonFogasview.Click += new System.EventHandler(this.buttonFogasview_Click);
            // 
            // buttonHozzavalo
            // 
            this.buttonHozzavalo.Location = new System.Drawing.Point(29, 77);
            this.buttonHozzavalo.Name = "buttonHozzavalo";
            this.buttonHozzavalo.Size = new System.Drawing.Size(122, 28);
            this.buttonHozzavalo.TabIndex = 2;
            this.buttonHozzavalo.Text = "Hozzávaló számítás";
            this.buttonHozzavalo.UseVisualStyleBackColor = true;
            this.buttonHozzavalo.Click += new System.EventHandler(this.buttonHozzavalo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 604);
            this.Controls.Add(this.buttonHozzavalo);
            this.Controls.Add(this.buttonFogasview);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonFogasview;
        private Button buttonHozzavalo;
    }
}
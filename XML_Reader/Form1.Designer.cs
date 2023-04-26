
namespace XML_Reader
{
    partial class Form1
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
            this.lbDados = new System.Windows.Forms.ListBox();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.btnLeXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDados
            // 
            this.lbDados.FormattingEnabled = true;
            this.lbDados.ItemHeight = 16;
            this.lbDados.Location = new System.Drawing.Point(12, 12);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(292, 340);
            this.lbDados.TabIndex = 0;
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(315, 12);
            this.txtDados.Multiline = true;
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(292, 339);
            this.txtDados.TabIndex = 1;
            // 
            // btnLeXml
            // 
            this.btnLeXml.Location = new System.Drawing.Point(12, 366);
            this.btnLeXml.Name = "btnLeXml";
            this.btnLeXml.Size = new System.Drawing.Size(595, 39);
            this.btnLeXml.TabIndex = 2;
            this.btnLeXml.Text = "Ler XML";
            this.btnLeXml.UseVisualStyleBackColor = true;
            this.btnLeXml.Click += new System.EventHandler(this.btnLeXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 419);
            this.Controls.Add(this.btnLeXml);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.lbDados);
            this.Name = "Form1";
            this.Text = "XML Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDados;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Button btnLeXml;
    }
}


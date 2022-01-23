
namespace OOPExamples.WindowsEndPoint5
{
    partial class InvoiceFrm
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
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnJoin = new System.Windows.Forms.Button();
            this.GridInvoices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(42, 37);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(268, 83);
            this.BtnLoad.TabIndex = 0;
            this.BtnLoad.Text = "button1";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnJoin
            // 
            this.BtnJoin.Location = new System.Drawing.Point(42, 159);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(268, 83);
            this.BtnJoin.TabIndex = 1;
            this.BtnJoin.Text = "LINQ JOIN";
            this.BtnJoin.UseVisualStyleBackColor = true;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // GridInvoices
            // 
            this.GridInvoices.AllowUserToAddRows = false;
            this.GridInvoices.AllowUserToDeleteRows = false;
            this.GridInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInvoices.Location = new System.Drawing.Point(351, 37);
            this.GridInvoices.Name = "GridInvoices";
            this.GridInvoices.ReadOnly = true;
            this.GridInvoices.RowHeadersWidth = 51;
            this.GridInvoices.RowTemplate.Height = 29;
            this.GridInvoices.Size = new System.Drawing.Size(810, 501);
            this.GridInvoices.TabIndex = 2;
            // 
            // InvoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 632);
            this.Controls.Add(this.GridInvoices);
            this.Controls.Add(this.BtnJoin);
            this.Controls.Add(this.BtnLoad);
            this.Name = "InvoiceFrm";
            this.Text = "InoiceFrm";
            this.Load += new System.EventHandler(this.InvoiceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnJoin;
        private System.Windows.Forms.DataGridView GridInvoices;
    }
}
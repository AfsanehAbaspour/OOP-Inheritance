
namespace OOPExamples.WindowsEndPoint5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.GridPeople = new System.Windows.Forms.DataGridView();
            this.ColIsSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLinq01 = new System.Windows.Forms.Button();
            this.BtnLinq05 = new System.Windows.Forms.Button();
            this.BtnLinq04 = new System.Windows.Forms.Button();
            this.BtnLinq03 = new System.Windows.Forms.Button();
            this.BtnLinq02 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(12, 31);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(170, 27);
            this.TxtFirstName.TabIndex = 0;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(36, 83);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(90, 42);
            this.BtnInsert.TabIndex = 1;
            this.BtnInsert.Text = "button1";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // GridPeople
            // 
            this.GridPeople.AllowUserToAddRows = false;
            this.GridPeople.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.GridPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.GridPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIsSelect,
            this.ColID,
            this.ColFullName,
            this.ColBirthDate,
            this.ColAge,
            this.ColMaritalStatus});
            this.GridPeople.Location = new System.Drawing.Point(12, 141);
            this.GridPeople.Name = "GridPeople";
            this.GridPeople.ReadOnly = true;
            this.GridPeople.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.GridPeople.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GridPeople.RowTemplate.Height = 29;
            this.GridPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPeople.Size = new System.Drawing.Size(1151, 517);
            this.GridPeople.TabIndex = 2;
            // 
            // ColIsSelect
            // 
            this.ColIsSelect.HeaderText = "";
            this.ColIsSelect.MinimumWidth = 6;
            this.ColIsSelect.Name = "ColIsSelect";
            this.ColIsSelect.ReadOnly = true;
            this.ColIsSelect.Width = 125;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ID";
            this.ColID.HeaderText = "شناسه";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // ColFullName
            // 
            this.ColFullName.DataPropertyName = "TitleFullName";
            this.ColFullName.HeaderText = "نام و نام خانوادگی";
            this.ColFullName.MinimumWidth = 6;
            this.ColFullName.Name = "ColFullName";
            this.ColFullName.ReadOnly = true;
            this.ColFullName.Width = 300;
            // 
            // ColBirthDate
            // 
            this.ColBirthDate.DataPropertyName = "PersianBirthDate";
            this.ColBirthDate.HeaderText = "تاریخ تولد";
            this.ColBirthDate.MinimumWidth = 6;
            this.ColBirthDate.Name = "ColBirthDate";
            this.ColBirthDate.ReadOnly = true;
            this.ColBirthDate.Width = 125;
            // 
            // ColAge
            // 
            this.ColAge.DataPropertyName = "Age";
            this.ColAge.HeaderText = "سن";
            this.ColAge.MinimumWidth = 6;
            this.ColAge.Name = "ColAge";
            this.ColAge.ReadOnly = true;
            this.ColAge.Width = 125;
            // 
            // ColMaritalStatus
            // 
            this.ColMaritalStatus.DataPropertyName = "MaritalStatus";
            this.ColMaritalStatus.HeaderText = "وضعیت تاهل";
            this.ColMaritalStatus.MinimumWidth = 6;
            this.ColMaritalStatus.Name = "ColMaritalStatus";
            this.ColMaritalStatus.ReadOnly = true;
            this.ColMaritalStatus.Width = 125;
            // 
            // BtnLinq01
            // 
            this.BtnLinq01.Location = new System.Drawing.Point(1073, 83);
            this.BtnLinq01.Name = "BtnLinq01";
            this.BtnLinq01.Size = new System.Drawing.Size(90, 42);
            this.BtnLinq01.TabIndex = 3;
            this.BtnLinq01.Text = "button1";
            this.BtnLinq01.UseVisualStyleBackColor = true;
            this.BtnLinq01.Click += new System.EventHandler(this.BtnLinq01_Click);
            // 
            // BtnLinq05
            // 
            this.BtnLinq05.Location = new System.Drawing.Point(551, 83);
            this.BtnLinq05.Name = "BtnLinq05";
            this.BtnLinq05.Size = new System.Drawing.Size(90, 42);
            this.BtnLinq05.TabIndex = 4;
            this.BtnLinq05.Text = "button2";
            this.BtnLinq05.UseVisualStyleBackColor = true;
            this.BtnLinq05.Click += new System.EventHandler(this.BtnLinq05_Click);
            // 
            // BtnLinq04
            // 
            this.BtnLinq04.Location = new System.Drawing.Point(679, 83);
            this.BtnLinq04.Name = "BtnLinq04";
            this.BtnLinq04.Size = new System.Drawing.Size(90, 42);
            this.BtnLinq04.TabIndex = 5;
            this.BtnLinq04.Text = "button3";
            this.BtnLinq04.UseVisualStyleBackColor = true;
            this.BtnLinq04.Click += new System.EventHandler(this.BtnLinq04_Click);
            // 
            // BtnLinq03
            // 
            this.BtnLinq03.Location = new System.Drawing.Point(815, 83);
            this.BtnLinq03.Name = "BtnLinq03";
            this.BtnLinq03.Size = new System.Drawing.Size(90, 42);
            this.BtnLinq03.TabIndex = 6;
            this.BtnLinq03.Text = "button4";
            this.BtnLinq03.UseVisualStyleBackColor = true;
            this.BtnLinq03.Click += new System.EventHandler(this.BtnLinq03_Click);
            // 
            // BtnLinq02
            // 
            this.BtnLinq02.Location = new System.Drawing.Point(953, 83);
            this.BtnLinq02.Name = "BtnLinq02";
            this.BtnLinq02.Size = new System.Drawing.Size(90, 42);
            this.BtnLinq02.TabIndex = 7;
            this.BtnLinq02.Text = "button5";
            this.BtnLinq02.UseVisualStyleBackColor = true;
            this.BtnLinq02.Click += new System.EventHandler(this.BtnLinq02_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 670);
            this.Controls.Add(this.BtnLinq02);
            this.Controls.Add(this.BtnLinq03);
            this.Controls.Add(this.BtnLinq04);
            this.Controls.Add(this.BtnLinq05);
            this.Controls.Add(this.BtnLinq01);
            this.Controls.Add(this.GridPeople);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TxtFirstName);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.DataGridView GridPeople;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColIsSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaritalStatus;
        private System.Windows.Forms.Button BtnLinq01;
        private System.Windows.Forms.Button BtnLinq05;
        private System.Windows.Forms.Button BtnLinq04;
        private System.Windows.Forms.Button BtnLinq03;
        private System.Windows.Forms.Button BtnLinq02;
    }
}



namespace OOPExamples.WindowsEndPoint
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
            this.saveButton1 = new CommonButtons.SaveButton();
            this.saveButton2 = new CommonButtons.SaveButton();
            this.cancelButton1 = new CommonButtons.CancelButton();
            this.SuspendLayout();
            // 
            // saveButton1
            // 
            this.saveButton1.BackColor = System.Drawing.Color.Green;
            this.saveButton1.ForeColor = System.Drawing.Color.White;
            this.saveButton1.Location = new System.Drawing.Point(63, 38);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(150, 50);
            this.saveButton1.TabIndex = 0;
            this.saveButton1.Text = "saveButton1";
            this.saveButton1.UseVisualStyleBackColor = false;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // saveButton2
            // 
            this.saveButton2.BackColor = System.Drawing.Color.Green;
            this.saveButton2.ForeColor = System.Drawing.Color.White;
            this.saveButton2.Location = new System.Drawing.Point(63, 186);
            this.saveButton2.Name = "saveButton2";
            this.saveButton2.Size = new System.Drawing.Size(150, 50);
            this.saveButton2.TabIndex = 1;
            this.saveButton2.Text = "saveButton2";
            this.saveButton2.UseVisualStyleBackColor = false;
            // 
            // cancelButton1
            // 
            this.cancelButton1.BackColor = System.Drawing.Color.Red;
            this.cancelButton1.ForeColor = System.Drawing.Color.White;
            this.cancelButton1.Location = new System.Drawing.Point(63, 108);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(150, 50);
            this.cancelButton1.TabIndex = 2;
            this.cancelButton1.Text = "cancelButton1";
            this.cancelButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 586);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.saveButton2);
            this.Controls.Add(this.saveButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CommonButtons.SaveButton saveButton1;
        private CommonButtons.SaveButton saveButton2;
        private CommonButtons.CancelButton cancelButton1;
    }
}


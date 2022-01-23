using System;
using System.Windows.Forms;

namespace CommonButtons
{
    public class SaveButton : Button
    {
        public SaveButton()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.ForeColor = System.Drawing.Color.White;
            this.Text = "ثبت اطلاعات";
            this.Size = new System.Drawing.Size(150, 50);

            this.Click += SaveButton_Click;


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SadrTools.Utility.MBox.DisplayInformation();
        }
    }
}

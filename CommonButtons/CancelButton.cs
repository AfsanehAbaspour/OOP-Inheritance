using SadrTools.Utility;
using System.Windows.Forms;

namespace CommonButtons
{
    public class CancelButton : Button
    {
        public CancelButton()
        {
            this.BackColor = System.Drawing.Color.Red;
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(150, 50);

            this.Text = "انصراف";

            this.Click += CancelButton_Click;

        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show("آیا مطمئن هستید ؟");

            // SadrTools.Utility.MBox.AskQuestion();

            MBox.AskQuestion();
        }
    }
}

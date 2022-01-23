using System;
using System.Windows.Forms;

namespace SadrTools.Utility
{
    public static class MBox
    {
        public static DialogResult AskQuestion(string text = "آیا از انجام این عملیات اطمینان دارید؟" , string caption = "تایید")
        {
           return MessageBox.Show(text,caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        public static void DisplayInformation(string text = " این عملیات انجام شد ", string caption = "پیام")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

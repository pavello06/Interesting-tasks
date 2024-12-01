using System.Windows.Forms;

namespace Tree
{
    public class ErrorBox
    {
        public void Show(string errorText)
        {
            MessageBox.Show(
                Program.ActionForm,
                @errorText, 
                @"Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error, 
                MessageBoxDefaultButton.Button1);
        }
    }
}
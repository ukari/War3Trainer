using System;
using System.Drawing;
using System.Windows.Forms;

namespace War3Trainer
{
    public class InputBox
    {
        public static string Show(string title, string text)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            string result = ""; 

            form.Text = title;
            label.Text = text;
            textBox.Text = "";
            buttonOk.Text = "确定";
            buttonCancel.Text = "取消";

            label.SetBounds(11, 15, 210, 80);
            textBox.SetBounds(11, 40, 60, 20);
            buttonOk.SetBounds(250, 0, 64, 24);
            buttonCancel.SetBounds(250, 40, 64, 24);

            label.AutoSize = true;
            textBox.Anchor = AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Right;

            form.ClientSize = new Size(320, 60);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(320, label.Height + form.ClientSize.Height + 15);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            buttonOk.Click += (object sender, EventArgs e) =>
            {
                result = textBox.Text;
                form.Close();
            };
            form.ShowDialog();
            return result;
        }
    }
}
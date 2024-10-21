using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MolodchikovEE.Sprint7.Project.V3
{
    public partial class FormAddSubject : Form
    {

        public string SubjectName { get; private set; }

        private TextBox textBoxSubject;
        private Button buttonOK;
        private Button buttonCancel;


        public FormAddSubject()
        {
            Text = "Добавить новый предмет";
            Size = new Size(300, 150);
            this.StartPosition = FormStartPosition.CenterParent;

            textBoxSubject = new TextBox() { Left = 20, Top = 20, Width = 240 };
            Controls.Add(textBoxSubject);

            buttonOK = new Button() { Text = "OK", Left = 50, Top = 60, Width = 75 };
            buttonOK.Click += ButtonOK_Click;
            Controls.Add(buttonOK);

            buttonCancel = new Button() { Text = "Отмена", Left = 150, Top = 60, Width = 75 };
            buttonCancel.Click += (sender, e) => { DialogResult = DialogResult.Cancel; Close(); };
            Controls.Add(buttonCancel);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSubject.Text))
            {
                SubjectName = textBoxSubject.Text.Trim();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите название предмета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }    
}

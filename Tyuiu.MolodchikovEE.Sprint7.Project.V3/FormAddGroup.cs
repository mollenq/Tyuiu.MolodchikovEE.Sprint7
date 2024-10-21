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
    public partial class FormAddGroup : Form
    {
        public string GroupName { get; private set; }

        private TextBox textBoxGroupName;
        private Button buttonOk;
        private Button buttonCancel;

        public FormAddGroup()
        {
            this.Text = "Добавить новую группу";
            this.Size = new Size(300, 150);
            this.StartPosition = FormStartPosition.CenterParent;

            textBoxGroupName = new TextBox() { Location = new Point(30, 30), Width = 200 };
            this.Controls.Add(textBoxGroupName);

            buttonOk = new Button() { Text = "OK", Location = new Point(30, 70), DialogResult = DialogResult.OK };
            this.Controls.Add(buttonOk);

            buttonCancel = new Button() { Text = "Отмена", Location = new Point(150, 70), DialogResult = DialogResult.Cancel };
            this.Controls.Add(buttonCancel);

            this.AcceptButton = buttonOk;
            this.CancelButton = buttonCancel;

            buttonOk.Click += (sender, e) =>
            {
                GroupName = textBoxGroupName.Text.Trim();
                if (string.IsNullOrEmpty(GroupName))
                {
                    MessageBox.Show("Название группы не может быть пустым.");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            };

            buttonCancel.Click += (sender, e) => this.Close();
        }

    }
}

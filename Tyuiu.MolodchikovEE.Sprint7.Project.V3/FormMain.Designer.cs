namespace Tyuiu.MolodchikovEE.Sprint7.Project.V3
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            buttonGiveGroup_MEE = new Button();
            buttonAddSubject_MEE = new Button();
            buttonDeleteGroup_MEE = new Button();
            buttonDeleteSubject_MEE = new Button();
            dataGridView_MEE = new DataGridView();
            comboBoxGroup_MEE = new ComboBox();
            comboBoxSubjects_MEE = new ComboBox();
            toolTip_MEE = new ToolTip(components);
            openFileDialog_MEE = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView_MEE).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(33, 48);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 1;
            label1.Text = "Выбор группы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(33, 208);
            label2.Name = "label2";
            label2.Size = new Size(145, 19);
            label2.TabIndex = 3;
            label2.Text = "Выбор предмета";
            // 
            // buttonGiveGroup_MEE
            // 
            buttonGiveGroup_MEE.BackColor = Color.LightGreen;
            buttonGiveGroup_MEE.FlatAppearance.BorderSize = 0;
            buttonGiveGroup_MEE.FlatStyle = FlatStyle.Flat;
            buttonGiveGroup_MEE.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonGiveGroup_MEE.ForeColor = Color.White;
            buttonGiveGroup_MEE.Location = new Point(33, 119);
            buttonGiveGroup_MEE.Name = "buttonGiveGroup_MEE";
            buttonGiveGroup_MEE.Size = new Size(102, 55);
            buttonGiveGroup_MEE.TabIndex = 4;
            buttonGiveGroup_MEE.Text = "Добавить";
            toolTip_MEE.SetToolTip(buttonGiveGroup_MEE, "Добавить дополнительную группу");
            buttonGiveGroup_MEE.UseVisualStyleBackColor = false;
            buttonGiveGroup_MEE.Click += buttonAddGroup_Click;
            // 
            // buttonAddSubject_MEE
            // 
            buttonAddSubject_MEE.BackColor = Color.LightGreen;
            buttonAddSubject_MEE.FlatAppearance.BorderSize = 0;
            buttonAddSubject_MEE.FlatStyle = FlatStyle.Flat;
            buttonAddSubject_MEE.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonAddSubject_MEE.ForeColor = Color.White;
            buttonAddSubject_MEE.Location = new Point(33, 287);
            buttonAddSubject_MEE.Name = "buttonAddSubject_MEE";
            buttonAddSubject_MEE.Size = new Size(102, 55);
            buttonAddSubject_MEE.TabIndex = 5;
            buttonAddSubject_MEE.Text = "Добавить";
            toolTip_MEE.SetToolTip(buttonAddSubject_MEE, "Добавить дополнительный предмет");
            buttonAddSubject_MEE.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteGroup_MEE
            // 
            buttonDeleteGroup_MEE.BackColor = Color.IndianRed;
            buttonDeleteGroup_MEE.FlatAppearance.BorderSize = 0;
            buttonDeleteGroup_MEE.FlatStyle = FlatStyle.Flat;
            buttonDeleteGroup_MEE.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonDeleteGroup_MEE.ForeColor = Color.White;
            buttonDeleteGroup_MEE.Location = new Point(148, 119);
            buttonDeleteGroup_MEE.Name = "buttonDeleteGroup_MEE";
            buttonDeleteGroup_MEE.Size = new Size(102, 55);
            buttonDeleteGroup_MEE.TabIndex = 6;
            buttonDeleteGroup_MEE.Text = "Удалить";
            toolTip_MEE.SetToolTip(buttonDeleteGroup_MEE, "Удалить выбранную групп");
            buttonDeleteGroup_MEE.UseVisualStyleBackColor = false;
            buttonDeleteGroup_MEE.Click += buttonDeleteGroup_MEE_Click;
            // 
            // buttonDeleteSubject_MEE
            // 
            buttonDeleteSubject_MEE.BackColor = Color.IndianRed;
            buttonDeleteSubject_MEE.FlatAppearance.BorderSize = 0;
            buttonDeleteSubject_MEE.FlatStyle = FlatStyle.Flat;
            buttonDeleteSubject_MEE.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonDeleteSubject_MEE.ForeColor = Color.White;
            buttonDeleteSubject_MEE.Location = new Point(148, 287);
            buttonDeleteSubject_MEE.Name = "buttonDeleteSubject_MEE";
            buttonDeleteSubject_MEE.Size = new Size(102, 55);
            buttonDeleteSubject_MEE.TabIndex = 7;
            buttonDeleteSubject_MEE.Text = "Удалить";
            toolTip_MEE.SetToolTip(buttonDeleteSubject_MEE, "Удалить данный предмет");
            buttonDeleteSubject_MEE.UseVisualStyleBackColor = false;
            // 
            // dataGridView_MEE
            // 
            dataGridView_MEE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_MEE.Location = new Point(413, 12);
            dataGridView_MEE.Name = "dataGridView_MEE";
            dataGridView_MEE.Size = new Size(559, 537);
            dataGridView_MEE.TabIndex = 8;
            // 
            // comboBoxGroup_MEE
            // 
            comboBoxGroup_MEE.BackColor = Color.LightGray;
            comboBoxGroup_MEE.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGroup_MEE.Font = new Font("Arial", 12F, FontStyle.Bold);
            comboBoxGroup_MEE.ForeColor = Color.DarkSlateGray;
            comboBoxGroup_MEE.FormattingEnabled = true;
            comboBoxGroup_MEE.Location = new Point(33, 81);
            comboBoxGroup_MEE.Name = "comboBoxGroup_MEE";
            comboBoxGroup_MEE.Size = new Size(294, 27);
            comboBoxGroup_MEE.TabIndex = 9;
            comboBoxGroup_MEE.SelectedIndexChanged += comboBoxGroup_SelectedIndexChanged;
            // 
            // comboBoxSubjects_MEE
            // 
            comboBoxSubjects_MEE.BackColor = Color.LightGray;
            comboBoxSubjects_MEE.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubjects_MEE.Font = new Font("Arial", 12F, FontStyle.Bold);
            comboBoxSubjects_MEE.ForeColor = Color.DarkSlateGray;
            comboBoxSubjects_MEE.FormattingEnabled = true;
            comboBoxSubjects_MEE.Location = new Point(33, 245);
            comboBoxSubjects_MEE.Name = "comboBoxSubjects_MEE";
            comboBoxSubjects_MEE.Size = new Size(294, 27);
            comboBoxSubjects_MEE.TabIndex = 10;
            comboBoxSubjects_MEE.SelectedIndexChanged += comboBoxSubject_SelectedIndexChanged;
            // 
            // toolTip_MEE
            // 
            toolTip_MEE.IsBalloon = true;
            toolTip_MEE.Tag = "";
            toolTip_MEE.ToolTipIcon = ToolTipIcon.Info;
            toolTip_MEE.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_MEE
            // 
            openFileDialog_MEE.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(comboBoxSubjects_MEE);
            Controls.Add(comboBoxGroup_MEE);
            Controls.Add(dataGridView_MEE);
            Controls.Add(buttonDeleteSubject_MEE);
            Controls.Add(buttonDeleteGroup_MEE);
            Controls.Add(buttonAddSubject_MEE);
            Controls.Add(buttonGiveGroup_MEE);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Университет - онлайн дневник";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_MEE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button buttonGiveGroup_MEE;
        private Button buttonAddSubject_MEE;
        private Button buttonDeleteGroup_MEE;
        private Button buttonDeleteSubject_MEE;
        private DataGridView dataGridView_MEE;
        private ComboBox comboBoxGroup_MEE;
        private ComboBox comboBoxSubjects_MEE;
        private ToolTip toolTip_MEE;
        private OpenFileDialog openFileDialog_MEE;
    }
}

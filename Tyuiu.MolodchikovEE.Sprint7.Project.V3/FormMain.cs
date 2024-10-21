using System.Data;
using Tyuiu.MolodchikovEE.Sprint7.Project.V3.Lib;

namespace Tyuiu.MolodchikovEE.Sprint7.Project.V3
{
    public partial class FormMain : Form
    {

        DataService ds = new DataService();
        private string databasePath = @"C:\База данных";
        private string currentFilePath;


        public FormMain()
        {
            InitializeComponent();
            comboBoxGroup_MEE.SelectedIndexChanged += comboBoxGroup_SelectedIndexChanged;
            comboBoxSubjects_MEE.SelectedIndexChanged += comboBoxSubject_SelectedIndexChanged;
            buttonDeleteGroup_MEE.Enabled = false;
            buttonDeleteSubject_MEE.Enabled = false;
            buttonAddSubject_MEE.Click += buttonAddSubject_MEE_Click;
            buttonDeleteSubject_MEE.Enabled = false;
            comboBoxSubjects_MEE.SelectedIndexChanged += comboBoxSubjects_MEE_SelectedIndexChanged;
            dataGridView_MEE.CellValueChanged += DataGridView_MEE_CellValueChanged;
            buttonAddSubject_MEE.Enabled = false;
            comboBoxGroup_MEE.SelectedIndexChanged += comboBoxGroup_SelectedIndexChanged;
            buttonDeleteSubject_MEE.Click += buttonDeleteSubject_MEE_Click;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxGroup_MEE.Items.Add("ИИПб-24-1");
            comboBoxGroup_MEE.Items.Add("РППб-24-1");
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubjects_MEE.Items.Clear();

            if (comboBoxGroup_MEE.SelectedItem != null)
            {
                string group = comboBoxGroup_MEE.SelectedItem.ToString();
                string[] subjects = GetSubjectsForGroup(group);

                if (subjects.Length > 0)
                {
                    comboBoxSubjects_MEE.Items.AddRange(subjects);
                }
            }

            if (comboBoxGroup_MEE.SelectedItem != null)
            {
                buttonDeleteGroup_MEE.Enabled = true;
            }
            else
            {
                buttonDeleteGroup_MEE.Enabled = false;
            }
            if (comboBoxGroup_MEE.SelectedIndex >= 0)
            {
                buttonAddSubject_MEE.Enabled = true;
            }
            else
            {
                buttonAddSubject_MEE.Enabled = false;
            }
        }

        private string[] GetSubjectsForGroup(string group)
        {
            if (group == "ИИПб-24-1" || group == "РППб-24-1")
            {
                return new string[]
                {
            "Алгебра и геометрия",
            "Дискретная математика",
            "Иностранный язык",
            "Математический анализ",
            "Основы российской государственности",
            "Программирование",
            "Проектная деятельность",
            "Теоретическая и прикладная информатика",
            "Физическая культура и спорт"
                };
            }
            return new string[0];

        }
        private void comboBoxSubjects_MEE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubjects_MEE.SelectedItem != null)
            {
                buttonDeleteSubject_MEE.Enabled = true;
            }
            else
            {
                buttonDeleteSubject_MEE.Enabled = false;
            }
        }

        public void LoadDataToGridView(string group, string subject)
        {
            string fileName = $"{group}_{subject}.csv";
            string filePath = Path.Combine(databasePath, fileName);

            if (File.Exists(filePath))
            {
                LoadCsvToDataGridView(filePath);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Файл {fileName} не найден. Создать новый файл?",
                                                      "Файл не найден", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string studentsListPath = Path.Combine(databasePath, $"Список_{group}.csv");

                    if (File.Exists(studentsListPath))
                    {
                        string[] students = File.ReadAllLines(studentsListPath);

                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            sw.WriteLine("ФИО,Оценка,Примечание");

                            foreach (string student in students)
                            {
                                sw.WriteLine($"{student},,");
                            }
                        }

                        LoadCsvToDataGridView(filePath);
                    }
                    else
                    {
                        MessageBox.Show($"Файл со списком студентов для группы {group} не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadCsvToDataGridView(string filePath)
        {
            currentFilePath = filePath;
            try
            {
                DataTable csvData = new DataTable();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        csvData.Columns.Add(header);
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        csvData.Rows.Add(rows);
                    }
                }

                dataGridView_MEE.DataSource = csvData;
                dataGridView_MEE.Columns[0].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGroup_MEE.SelectedItem != null && comboBoxSubjects_MEE.SelectedItem != null)
            {
                string group = comboBoxGroup_MEE.SelectedItem.ToString();
                string subject = comboBoxSubjects_MEE.SelectedItem.ToString();

                LoadDataToGridView(group, subject);
            }
        }
        private void DataGridView_MEE_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SaveDataGridViewToCsv(currentFilePath);
        }

        private void SaveDataGridViewToCsv(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    string[] columnNames = dataGridView_MEE.Columns
                        .Cast<DataGridViewColumn>()
                        .Select(column => column.HeaderText)
                        .ToArray();
                    sw.WriteLine(string.Join(",", columnNames));

                    foreach (DataGridViewRow row in dataGridView_MEE.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string[] rowData = row.Cells
                                .Cast<DataGridViewCell>()
                                .Select(cell => cell.Value?.ToString() ?? "")
                                .ToArray();
                            sw.WriteLine(string.Join(",", rowData));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            FormAddGroup addGroupForm = new FormAddGroup();

            if (addGroupForm.ShowDialog() == DialogResult.OK)
            {
                string newGroupName = addGroupForm.GroupName;

                if (!comboBoxGroup_MEE.Items.Contains(newGroupName))
                {
                    comboBoxGroup_MEE.Items.Add(newGroupName);
                }
                else
                {
                    MessageBox.Show("Группа с таким названием уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void buttonDeleteGroup_MEE_Click(object sender, EventArgs e)
        {
            if (comboBoxGroup_MEE.SelectedItem != null)
            {
                string selectedGroup = comboBoxGroup_MEE.SelectedItem.ToString();

                DialogResult result = MessageBox.Show($"Все предметы группы {selectedGroup} будут удалены. Вы уверены?",
                                                      "Подтверждение удаления",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    comboBoxGroup_MEE.Items.Remove(selectedGroup);
                    comboBoxSubjects_MEE.Items.Clear();
                    DeleteGroupFiles(selectedGroup);

                    MessageBox.Show($"Группа {selectedGroup} и все её предметы удалены.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите группу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteGroupFiles(string group)
        {
            try
            {
                string[] files = Directory.GetFiles(databasePath, $"{group}_*.csv");

                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении файлов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAddSubject_MEE_Click(object sender, EventArgs e)
        {
            FormAddSubject addSubjectForm = new FormAddSubject();

            if (addSubjectForm.ShowDialog() == DialogResult.OK)
            {
                string newSubject = addSubjectForm.SubjectName;

                if (!comboBoxSubjects_MEE.Items.Contains(newSubject))
                {
                    comboBoxSubjects_MEE.Items.Add(newSubject);
                    MessageBox.Show($"Предмет '{newSubject}' успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Предмет '{newSubject}' уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonDeleteSubject_MEE_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects_MEE.SelectedItem != null)
            {
                string selectedSubject = comboBoxSubjects_MEE.SelectedItem.ToString();

                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить предмет \"{selectedSubject}\"?",
                                                      "Удаление предмета",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    comboBoxSubjects_MEE.Items.Remove(selectedSubject);
                    comboBoxSubjects_MEE.SelectedItem = null;
                    dataGridView_MEE.Columns.Clear();

                    if (comboBoxSubjects_MEE.Items.Count == 0)
                    {
                        buttonDeleteSubject_MEE.Enabled = false;
                    }
                }
            }
        }
    }
}

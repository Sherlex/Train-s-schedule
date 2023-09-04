using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr4x
{
    public partial class Form1 : Form
    {
        private TrainScheduleDB schedule_list = new TrainScheduleDB("lrr4.sqlite", "TrainSchedule");
        public string[] data_edit;
        public Form1()
        {
            InitializeComponent();
            bool connected_succesfully = schedule_list.ConnectToExisting();
            if (connected_succesfully)
            {
                StatusLabel.Text = "БД Подключена";
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Для начала работы создайте БД.", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning,
                    caption: "Внимание");
            }
        }
        private void UpdateDataGridView()
        {
            DataTable data_table = schedule_list.ReadAll();
            if (data_table.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < data_table.Rows.Count; ++i)
                {
                    dataGridView1.Rows.Add(data_table.Rows[i].ItemArray);
                }
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            bool created_succesfully = schedule_list.CreateAndConnect();
            if (created_succesfully)
            {
                StatusLabel.Text = "БД Подключена";
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show(text: "БД уже была создана.", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information,
                    caption: "Внимание");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!schedule_list.IsConnected)
            {
                MessageBox.Show("БД не подключена.");
                return;
            }

            Data dataForm = new Data();
            if (dataForm.ShowDialog() == DialogResult.OK)
            {
                TrainSchedule item = new TrainSchedule(dataForm.Number, dataForm.Departure, dataForm.Arrival, dataForm.Departure_time, dataForm.Arrival_time);
                schedule_list.Add(item);
                UpdateDataGridView();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(text: "Вы уверены, что хотите удалить все данные?",
                caption: "Внимание", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                schedule_list.ClearAll();
                dataGridView1.Rows.Clear();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Автор программы: Голова Елена, 474\n" +
                "Назначение программы - работа с базой данных, хранящей \n" +
                "расписание поездов.\n\n",
                caption: "О программе",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "xlsx files (*.xlsx)|*.xlsx|All files(*.*)|*.*";
            string file_name = string.Empty;

            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelapp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;

            if (save.ShowDialog() == DialogResult.OK)
            {
                file_name = save.FileName;
                try
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            worksheet.Rows[i + 1].Columns[j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }
                    excelapp.AlertBeforeOverwriting = false;
                    workbook.SaveAs(file_name, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    save.Dispose();
                    excelapp.Quit();

                    MessageBox.Show(text: "Данные сохранены успешно! :)", caption: "Информация",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(text: "При сохранении данных произошла ошибка!", caption: "Ошибка!",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(text: "Вы уверены, что хотите удалить эту строку?",
                caption: "Внимание", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)(long)dataGridView1.Rows[e.Row.Index].Cells[0].Value;
                schedule_list.Delete(id);
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: "Для того, чтобы удалить строку выделите её щелчком левой кнопки мыши " +
                "и нажмите клавишу delete.\n\n" +
                "Чтобы редактировать строку, дважды кликните на неё. ", caption: "Помощь!",
                buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }
        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            data_edit = dataGridView1.CurrentRow.Cells.Cast<DataGridViewCell>().Select(cell => (cell.Value.ToString())).ToArray();
            Data dataForm = new Data();
            dataForm.Owner = this;
            if (dataForm.ShowDialog() == DialogResult.OK)
            {
                TrainSchedule item = new TrainSchedule(dataForm.Number, dataForm.Departure, dataForm.Arrival, dataForm.Departure_time, dataForm.Arrival_time);
                schedule_list.Edit(int.Parse(data_edit[0]), item);
                UpdateDataGridView();
            }
        }
    }
}

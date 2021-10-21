using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Lab_1
{

    public partial class TasksForm : Form
    {
        public TasksForm(string nameInput, string secondNameInput, string classNumber, decimal countTasks, bool isEasy)
        {
            InitializeComponent();
            var groupBox = new GroupBox();
            groupBox.Dock = DockStyle.Fill;
            groupBox.Text = $"{secondNameInput} {nameInput} {classNumber}";

            var panel = new TableLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.ColumnCount = 2;

            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66));

            panel.RowCount = ((int)countTasks) + 1;
            panel.AutoScroll = true;

            groupBox.Controls.Add(panel);

            for (int r = 0; r < panel.RowCount - 1; ++r)
            {
                var toolPanel = new TableLayoutPanel();
                toolPanel.Dock = DockStyle.Fill;
                toolPanel.ColumnCount = 2;
                toolPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                toolPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                toolPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                var task = new Label();
                task.Dock = DockStyle.Top;
                if (isEasy)
                {
                    task.Text = $"Простое задание #{r+1}";
                }
                else
                {
                    task.Text = $"Сложное задание #{r+1}";
                }
                
                panel.Controls.Add(task, 0, r);

                var firstRB = new RadioButton();
                firstRB.Dock = DockStyle.Top;
                if (!isEasy)
                {
                    firstRB.Text = "Сложный ответ 1";
                }
                else
                {
                    firstRB.Text = "Простой ответ 1";
                }

                var secondRB = new RadioButton();
                secondRB.Dock = DockStyle.Top;
                if (!isEasy)
                {
                    secondRB.Text = "Сложный ответ 2";
                }
                else
                {
                    secondRB.Text = "Простой ответ 2";
                }


                toolPanel.Controls.Add(firstRB, 0, 0);
                toolPanel.Controls.Add(secondRB, 1, 0);
                panel.Controls.Add(toolPanel, 1, r);

            }
            var submitBrn = new Button();
            submitBrn.Text = "Ответить";
            submitBrn.Dock = DockStyle.Top;
            submitBrn.Click += new System.EventHandler(onSubmitClick);
            panel.Controls.Add(submitBrn, 0, panel.RowCount);
            this.Controls.Add(groupBox);
        }
        private void onSubmitClick(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы прошли тест! Проверять мы его не будем, поставим вам зачет автоматом! Всего хорошего, берегите себя и соблюдайте масочный режим!");
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TasksForm_Load(object sender, EventArgs e)
        {

        }
    }
}

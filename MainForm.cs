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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void topGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDownCountTask_ValueChanged(object sender, EventArgs e)
        {

        }

        private void openTasks(object sender, EventArgs e)
        {
            if (secondNameInput.Text.Length == 0)
            {
                MessageBox.Show("Не введена фамилия");
                return;
            }
            else if (nameInput.Text.Length == 0)
            {
                MessageBox.Show("Не введено имя");
                return;
            }
            else if (classComboBox.Text.Length == 0)
            {
                MessageBox.Show("Не выбран класс");
                return;
            }
            else if (!easyRadioButton.Checked & !hardRadioButton.Checked)
            {
                MessageBox.Show("Не выбран уравень сложности!");
                return;
            }
            TasksForm tf = new TasksForm(
                nameInput.Text,
                secondNameInput.Text,
                classComboBox.Text,
                numericUpDownCountTask.Value,
                easyRadioButton.Checked);
            // radioButton1.Checked
            tf.ShowDialog();

        }
    }
}

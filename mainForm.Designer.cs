namespace Programming_Lab_1
{
    partial class mainForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topGroupBox = new System.Windows.Forms.GroupBox();
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.secondNameLable = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.classNumberLabel = new System.Windows.Forms.Label();
            this.secondNameInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.fatherNameInput = new System.Windows.Forms.TextBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.bottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelForCountTask = new System.Windows.Forms.Label();
            this.numericUpDownCountTask = new System.Windows.Forms.NumericUpDown();
            this.hardRadioButton = new System.Windows.Forms.RadioButton();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.createTaskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.topGroupBox.SuspendLayout();
            this.topTableLayoutPanel.SuspendLayout();
            this.bottomTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountTask)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.mainTableLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(564, 472);
            this.splitContainer.SplitterDistance = 409;
            this.splitContainer.TabIndex = 0;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.topGroupBox, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.bottomTableLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(564, 409);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // topGroupBox
            // 
            this.topGroupBox.Controls.Add(this.topTableLayoutPanel);
            this.topGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topGroupBox.Location = new System.Drawing.Point(3, 3);
            this.topGroupBox.Name = "topGroupBox";
            this.topGroupBox.Size = new System.Drawing.Size(558, 198);
            this.topGroupBox.TabIndex = 0;
            this.topGroupBox.TabStop = false;
            this.topGroupBox.Text = "Ученик";
            this.topGroupBox.Enter += new System.EventHandler(this.topGroupBox_Enter);
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 2;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topTableLayoutPanel.Controls.Add(this.secondNameLable, 0, 0);
            this.topTableLayoutPanel.Controls.Add(this.nameLabel, 0, 1);
            this.topTableLayoutPanel.Controls.Add(this.fatherNameLabel, 0, 2);
            this.topTableLayoutPanel.Controls.Add(this.classNumberLabel, 0, 3);
            this.topTableLayoutPanel.Controls.Add(this.secondNameInput, 1, 0);
            this.topTableLayoutPanel.Controls.Add(this.nameInput, 1, 1);
            this.topTableLayoutPanel.Controls.Add(this.fatherNameInput, 1, 2);
            this.topTableLayoutPanel.Controls.Add(this.classComboBox, 1, 3);
            this.topTableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 4;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(552, 172);
            this.topTableLayoutPanel.TabIndex = 0;
            // 
            // secondNameLable
            // 
            this.secondNameLable.AutoSize = true;
            this.secondNameLable.Cursor = System.Windows.Forms.Cursors.Default;
            this.secondNameLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondNameLable.Location = new System.Drawing.Point(3, 0);
            this.secondNameLable.Name = "secondNameLable";
            this.secondNameLable.Size = new System.Drawing.Size(270, 43);
            this.secondNameLable.TabIndex = 0;
            this.secondNameLable.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(270, 43);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.fatherNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fatherNameLabel.Location = new System.Drawing.Point(3, 86);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(270, 43);
            this.fatherNameLabel.TabIndex = 2;
            this.fatherNameLabel.Text = "Отчество";
            // 
            // classNumberLabel
            // 
            this.classNumberLabel.AutoSize = true;
            this.classNumberLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.classNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classNumberLabel.Location = new System.Drawing.Point(3, 129);
            this.classNumberLabel.Name = "classNumberLabel";
            this.classNumberLabel.Size = new System.Drawing.Size(270, 43);
            this.classNumberLabel.TabIndex = 3;
            this.classNumberLabel.Text = "Класс";
            // 
            // secondNameInput
            // 
            this.secondNameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondNameInput.Location = new System.Drawing.Point(279, 3);
            this.secondNameInput.Name = "secondNameInput";
            this.secondNameInput.Size = new System.Drawing.Size(270, 27);
            this.secondNameInput.TabIndex = 4;
            // 
            // nameInput
            // 
            this.nameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameInput.Location = new System.Drawing.Point(279, 46);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(270, 27);
            this.nameInput.TabIndex = 5;
            // 
            // fatherNameInput
            // 
            this.fatherNameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fatherNameInput.Location = new System.Drawing.Point(279, 89);
            this.fatherNameInput.Name = "fatherNameInput";
            this.fatherNameInput.Size = new System.Drawing.Size(270, 27);
            this.fatherNameInput.TabIndex = 6;
            // 
            // classComboBox
            // 
            this.classComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "9А",
            "9Б",
            "10А",
            "10Б"});
            this.classComboBox.Location = new System.Drawing.Point(279, 132);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(270, 28);
            this.classComboBox.TabIndex = 7;
            // 
            // bottomTableLayoutPanel
            // 
            this.bottomTableLayoutPanel.ColumnCount = 2;
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomTableLayoutPanel.Controls.Add(this.labelForCountTask, 0, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.numericUpDownCountTask, 1, 0);
            this.bottomTableLayoutPanel.Controls.Add(this.hardRadioButton, 0, 1);
            this.bottomTableLayoutPanel.Controls.Add(this.easyRadioButton, 1, 1);
            this.bottomTableLayoutPanel.Controls.Add(this.createTaskButton, 0, 2);
            this.bottomTableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.bottomTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomTableLayoutPanel.Location = new System.Drawing.Point(3, 207);
            this.bottomTableLayoutPanel.Name = "bottomTableLayoutPanel";
            this.bottomTableLayoutPanel.RowCount = 3;
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bottomTableLayoutPanel.Size = new System.Drawing.Size(558, 199);
            this.bottomTableLayoutPanel.TabIndex = 1;
            // 
            // labelForCountTask
            // 
            this.labelForCountTask.AutoSize = true;
            this.labelForCountTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelForCountTask.Location = new System.Drawing.Point(3, 0);
            this.labelForCountTask.Name = "labelForCountTask";
            this.labelForCountTask.Size = new System.Drawing.Size(273, 20);
            this.labelForCountTask.TabIndex = 0;
            this.labelForCountTask.Text = "Кол-во";
            this.labelForCountTask.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownCountTask
            // 
            this.numericUpDownCountTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownCountTask.Location = new System.Drawing.Point(282, 3);
            this.numericUpDownCountTask.Name = "numericUpDownCountTask";
            this.numericUpDownCountTask.Size = new System.Drawing.Size(273, 27);
            this.numericUpDownCountTask.TabIndex = 1;
            this.numericUpDownCountTask.ValueChanged += new System.EventHandler(this.numericUpDownCountTask_ValueChanged);
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.AutoSize = true;
            this.hardRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.hardRadioButton.Location = new System.Drawing.Point(3, 36);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(273, 24);
            this.hardRadioButton.TabIndex = 2;
            this.hardRadioButton.TabStop = true;
            this.hardRadioButton.Text = "Сложно";
            this.hardRadioButton.UseVisualStyleBackColor = true;
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.easyRadioButton.Location = new System.Drawing.Point(282, 36);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(273, 24);
            this.easyRadioButton.TabIndex = 3;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Легко";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            // 
            // createTaskButton
            // 
            this.createTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createTaskButton.Location = new System.Drawing.Point(3, 66);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(273, 33);
            this.createTaskButton.TabIndex = 4;
            this.createTaskButton.Text = "Создать задание";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.openTasks);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 472);
            this.Controls.Add(this.splitContainer);
            this.Name = "mainForm";
            this.Text = "Тесты";
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.topGroupBox.ResumeLayout(false);
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            this.bottomTableLayoutPanel.ResumeLayout(false);
            this.bottomTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.GroupBox topGroupBox;
        private System.Windows.Forms.TableLayoutPanel bottomTableLayoutPanel;
        private System.Windows.Forms.Label labelForCountTask;
        private System.Windows.Forms.NumericUpDown numericUpDownCountTask;
        private System.Windows.Forms.RadioButton hardRadioButton;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.Label secondNameLable;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.Label classNumberLabel;
        private System.Windows.Forms.TextBox secondNameInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox fatherNameInput;
        private System.Windows.Forms.ComboBox classComboBox;
    }
}


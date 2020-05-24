using System.ComponentModel;
using ScienceManager.DAL.Entities;

namespace ScienceManager {
    partial class WorkWithDataBaseWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.EmployeeDataGrid = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWorkPanel = new System.Windows.Forms.Panel();
            this.addNewDepartment = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.birthdayBox = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.RichTextBox();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.detailsTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.valueError = new System.Windows.Forms.ErrorProvider(this.components);
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.EmployeeDataGrid)).BeginInit();
            this.dataWorkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.valueError)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataGrid
            // 
            this.EmployeeDataGrid.AllowUserToAddRows = false;
            this.EmployeeDataGrid.AllowUserToDeleteRows = false;
            this.EmployeeDataGrid.AllowUserToResizeColumns = false;
            this.EmployeeDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.EmployeeDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Surname,
                this.Name,
                this.Patronymic,
                this.Department,
                this.Birthday,
                this.Address,
                this.Details,
                this.Id
            });
            this.EmployeeDataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.EmployeeDataGrid.Location = new System.Drawing.Point(107, 80);
            this.EmployeeDataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EmployeeDataGrid.Name = "EmployeeDataGrid";
            this.EmployeeDataGrid.Size = new System.Drawing.Size(1200, 666);
            this.EmployeeDataGrid.TabIndex = 0;
            this.EmployeeDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCellDoubleClick);
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 130;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Имя";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 130;
            // 
            // Patronymic
            // 
            this.Patronymic.DataPropertyName = "Patronymic";
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Width = 130;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Отдел";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // Details
            // 
            this.Details.DataPropertyName = "Details";
            this.Details.HeaderText = "О себе";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 195;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // dataWorkPanel
            // 
            this.dataWorkPanel.Controls.Add(this.addNewDepartment);
            this.dataWorkPanel.Controls.Add(this.DeleteButton);
            this.dataWorkPanel.Controls.Add(this.idLabel);
            this.dataWorkPanel.Controls.Add(this.UpdateButton);
            this.dataWorkPanel.Controls.Add(this.birthdayBox);
            this.dataWorkPanel.Controls.Add(this.addressTextBox);
            this.dataWorkPanel.Controls.Add(this.departmentBox);
            this.dataWorkPanel.Controls.Add(this.detailsTextBox);
            this.dataWorkPanel.Controls.Add(this.AddButton);
            this.dataWorkPanel.Controls.Add(this.patronymicTextBox);
            this.dataWorkPanel.Controls.Add(this.nameTextBox);
            this.dataWorkPanel.Controls.Add(this.surnameTextBox);
            this.dataWorkPanel.Controls.Add(this.detailsLabel);
            this.dataWorkPanel.Controls.Add(this.addressLabel);
            this.dataWorkPanel.Controls.Add(this.birthdayLabel);
            this.dataWorkPanel.Controls.Add(this.departmentLabel);
            this.dataWorkPanel.Controls.Add(this.patronymicLabel);
            this.dataWorkPanel.Controls.Add(this.nameLabel);
            this.dataWorkPanel.Controls.Add(this.surnameLabel);
            this.dataWorkPanel.Location = new System.Drawing.Point(1328, 14);
            this.dataWorkPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataWorkPanel.Name = "dataWorkPanel";
            this.dataWorkPanel.Size = new System.Drawing.Size(391, 745);
            this.dataWorkPanel.TabIndex = 1;
            // 
            // addNewDepartment
            // 
            this.addNewDepartment.Location = new System.Drawing.Point(244, 218);
            this.addNewDepartment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addNewDepartment.Name = "addNewDepartment";
            this.addNewDepartment.Size = new System.Drawing.Size(112, 42);
            this.addNewDepartment.TabIndex = 22;
            this.addNewDepartment.Text = "Добавить новый отдел";
            this.addNewDepartment.UseVisualStyleBackColor = true;
            this.addNewDepartment.Click += new System.EventHandler(this.AddNewDepartmentButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(156, 698);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(200, 35);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить сотрудника";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(295, 17);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 15);
            this.idLabel.TabIndex = 21;
            this.idLabel.Text = "ID: ";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(156, 657);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(200, 35);
            this.UpdateButton.TabIndex = 20;
            this.UpdateButton.Text = "Обновить данные сотрудника";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // birthdayBox
            // 
            this.birthdayBox.Location = new System.Drawing.Point(21, 297);
            this.birthdayBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.birthdayBox.Name = "birthdayBox";
            this.birthdayBox.Size = new System.Drawing.Size(334, 23);
            this.birthdayBox.TabIndex = 3;
            this.birthdayBox.Validating += new System.ComponentModel.CancelEventHandler(this.BirthdayValidate);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(19, 352);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(336, 78);
            this.addressTextBox.TabIndex = 18;
            this.addressTextBox.Text = "";
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddressValidate);
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(21, 228);
            this.departmentBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(172, 23);
            this.departmentBox.TabIndex = 1;
            this.departmentBox.Text = "Выберите отдел";
            this.departmentBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepatmentValidate);
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(19, 466);
            this.detailsTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(336, 141);
            this.detailsTextBox.TabIndex = 15;
            this.detailsTextBox.Text = "";
            this.detailsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DetailsValidate);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(156, 615);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(200, 35);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить сотрудника";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(21, 170);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(334, 23);
            this.patronymicTextBox.TabIndex = 9;
            this.patronymicTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PatronymicValidate);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(21, 112);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(334, 23);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameValidate);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(21, 52);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(334, 23);
            this.surnameTextBox.TabIndex = 7;
            this.surnameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SurnameValidate);
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(15, 448);
            this.detailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(44, 15);
            this.detailsLabel.TabIndex = 6;
            this.detailsLabel.Text = "О себе";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(18, 333);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(40, 15);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Адрес";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(18, 268);
            this.birthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(90, 15);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "Дата рождения";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(18, 210);
            this.departmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(40, 15);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Отдел";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(18, 151);
            this.patronymicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(58, 15);
            this.patronymicLabel.TabIndex = 2;
            this.patronymicLabel.Text = "Отчество";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 93);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(31, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(18, 33);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(58, 15);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Фамилия";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // valueError
            // 
            this.valueError.ContainerControl = this;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(1183, 14);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(124, 60);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Обновить базу данных";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // WorkWithDataBaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 760);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.dataWorkPanel);
            this.Controls.Add(this.EmployeeDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Text = "Работа с базой данных";
            ((System.ComponentModel.ISupportInitialize) (this.EmployeeDataGrid)).EndInit();
            this.dataWorkPanel.ResumeLayout(false);
            this.dataWorkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.valueError)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGrid;
        private System.Windows.Forms.Panel dataWorkPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.RichTextBox detailsTextBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birthdayBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.ErrorProvider valueError;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button addNewDepartment;
    }
}

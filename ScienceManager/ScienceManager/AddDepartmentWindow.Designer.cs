using System.ComponentModel;

namespace ScienceManager {
    partial class AddDepartmentWindow {
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
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.newDepartmentMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.nameNewDepartmentError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameNewDepartmentError)).BeginInit();
            this.SuspendLayout();
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Location = new System.Drawing.Point(92, 330);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(212, 36);
            this.addDepartmentButton.TabIndex = 0;
            this.addDepartmentButton.Text = "Добавить новый отдел";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.AddNewDepartmentClick);
            // 
            // newDepartmentMessage
            // 
            this.newDepartmentMessage.AutoSize = true;
            this.newDepartmentMessage.Location = new System.Drawing.Point(64, 88);
            this.newDepartmentMessage.Name = "newDepartmentMessage";
            this.newDepartmentMessage.Size = new System.Drawing.Size(124, 13);
            this.newDepartmentMessage.TabIndex = 1;
            this.newDepartmentMessage.Text = "Добавить новый отдел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название отдела";
            // 
            // newDepartmentTextBox
            // 
            this.newDepartmentTextBox.Location = new System.Drawing.Point(67, 215);
            this.newDepartmentTextBox.Name = "newDepartmentTextBox";
            this.newDepartmentTextBox.Size = new System.Drawing.Size(271, 20);
            this.newDepartmentTextBox.TabIndex = 3;
            this.newDepartmentTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NewNameDepartmentValidate);
            // 
            // nameNewDepartmentError
            // 
            this.nameNewDepartmentError.ContainerControl = this;
            // 
            // AddDepartmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 410);
            this.Controls.Add(this.newDepartmentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newDepartmentMessage);
            this.Controls.Add(this.addDepartmentButton);
            this.Name = "AddDepartmentWindow";
            this.Text = "AddDepartmentWindow";
            ((System.ComponentModel.ISupportInitialize)(this.nameNewDepartmentError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.Label newDepartmentMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newDepartmentTextBox;
        private System.Windows.Forms.ErrorProvider nameNewDepartmentError;
    }
}
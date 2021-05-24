
namespace DataBase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstName = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(114, 38);
            this.firstName.MaxLength = 50;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(233, 20);
            this.firstName.TabIndex = 0;
            this.firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstName_KeyPress);
            // 
            // label0
            // 
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label0.Location = new System.Drawing.Point(12, 36);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(95, 20);
            this.label0.TabIndex = 1;
            this.label0.Text = " First Name:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(5, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(114, 75);
            this.lastName.MaxLength = 50;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(233, 20);
            this.lastName.TabIndex = 5;
            this.lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastName_KeyPress);
            // 
            // phoneNum
            // 
            this.phoneNum.Location = new System.Drawing.Point(184, 112);
            this.phoneNum.MaxLength = 7;
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(163, 20);
            this.phoneNum.TabIndex = 6;
            this.phoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNum_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(163, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "-";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(114, 147);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(231, 20);
            this.dateOfBirth.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.Items.AddRange(new object[] {
            "050",
            "052",
            "053",
            "054",
            "057",
            "058"});
            this.comboBox1.Location = new System.Drawing.Point(114, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(113, 180);
            this.zipCode.MaxLength = 10;
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(232, 20);
            this.zipCode.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label5.Location = new System.Drawing.Point(14, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Zip Code:";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(113, 217);
            this.country.MaxLength = 50;
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(232, 20);
            this.country.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label6.Location = new System.Drawing.Point(14, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Country:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(102, 256);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(142, 35);
            this.submit.TabIndex = 15;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(99, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(97, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(99, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(357, 305);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.firstName);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox phoneNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}


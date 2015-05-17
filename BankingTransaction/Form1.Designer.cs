namespace BankingTransaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.accountBranchTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.balanceAccNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.accNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.branchRadioButton = new System.Windows.Forms.RadioButton();
            this.accNameRadioButton = new System.Windows.Forms.RadioButton();
            this.CommendLabel = new System.Windows.Forms.Label();
            this.showListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.accountBranchTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.accountNameTextBox);
            this.groupBox1.Controls.Add(this.accountNumberTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Account";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(272, 94);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // accountBranchTextBox
            // 
            this.accountBranchTextBox.Location = new System.Drawing.Point(117, 69);
            this.accountBranchTextBox.Name = "accountBranchTextBox";
            this.accountBranchTextBox.Size = new System.Drawing.Size(230, 20);
            this.accountBranchTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branch";
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Location = new System.Drawing.Point(117, 43);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.accountNameTextBox.TabIndex = 3;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(117, 19);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(230, 20);
            this.accountNumberTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.withdrawButton);
            this.groupBox2.Controls.Add(this.depositButton);
            this.groupBox2.Controls.Add(this.balanceTextBox);
            this.groupBox2.Controls.Add(this.balanceAccNumberTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(241, 94);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 8;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(142, 94);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 7;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(112, 53);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(230, 20);
            this.balanceTextBox.TabIndex = 5;
            // 
            // balanceAccNumberTextBox
            // 
            this.balanceAccNumberTextBox.Location = new System.Drawing.Point(112, 26);
            this.balanceAccNumberTextBox.Name = "balanceAccNumberTextBox";
            this.balanceAccNumberTextBox.Size = new System.Drawing.Size(230, 20);
            this.balanceAccNumberTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Account Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.accNumberRadioButton);
            this.groupBox3.Controls.Add(this.branchRadioButton);
            this.groupBox3.Controls.Add(this.accNameRadioButton);
            this.groupBox3.Controls.Add(this.CommendLabel);
            this.groupBox3.Controls.Add(this.showListView);
            this.groupBox3.Controls.Add(this.searchBalanceTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 296);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // accNumberRadioButton
            // 
            this.accNumberRadioButton.AutoSize = true;
            this.accNumberRadioButton.Checked = true;
            this.accNumberRadioButton.Location = new System.Drawing.Point(579, 51);
            this.accNumberRadioButton.Name = "accNumberRadioButton";
            this.accNumberRadioButton.Size = new System.Drawing.Size(105, 17);
            this.accNumberRadioButton.TabIndex = 12;
            this.accNumberRadioButton.TabStop = true;
            this.accNumberRadioButton.Text = "Account Number";
            this.accNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // branchRadioButton
            // 
            this.branchRadioButton.AutoSize = true;
            this.branchRadioButton.Location = new System.Drawing.Point(579, 107);
            this.branchRadioButton.Name = "branchRadioButton";
            this.branchRadioButton.Size = new System.Drawing.Size(59, 17);
            this.branchRadioButton.TabIndex = 11;
            this.branchRadioButton.Text = "Branch";
            this.branchRadioButton.UseVisualStyleBackColor = true;
            // 
            // accNameRadioButton
            // 
            this.accNameRadioButton.AutoSize = true;
            this.accNameRadioButton.Location = new System.Drawing.Point(579, 79);
            this.accNameRadioButton.Name = "accNameRadioButton";
            this.accNameRadioButton.Size = new System.Drawing.Size(96, 17);
            this.accNameRadioButton.TabIndex = 10;
            this.accNameRadioButton.Text = "Account Name";
            this.accNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // CommendLabel
            // 
            this.CommendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommendLabel.Location = new System.Drawing.Point(576, 174);
            this.CommendLabel.Name = "CommendLabel";
            this.CommendLabel.Size = new System.Drawing.Size(164, 21);
            this.CommendLabel.TabIndex = 9;
            // 
            // showListView
            // 
            this.showListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.showListView.FullRowSelect = true;
            this.showListView.GridLines = true;
            this.showListView.Location = new System.Drawing.Point(6, 19);
            this.showListView.Name = "showListView";
            this.showListView.Size = new System.Drawing.Size(551, 271);
            this.showListView.TabIndex = 8;
            this.showListView.UseCompatibleStateImageBehavior = false;
            this.showListView.View = System.Windows.Forms.View.Details;
            this.showListView.DoubleClick += new System.EventHandler(this.showListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Serial No.";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Account Number";
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Account Name";
            this.columnHeader4.Width = 146;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Branch";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Balance";
            this.columnHeader6.Width = 111;
            // 
            // searchBalanceTextBox
            // 
            this.searchBalanceTextBox.Location = new System.Drawing.Point(579, 135);
            this.searchBalanceTextBox.Name = "searchBalanceTextBox";
            this.searchBalanceTextBox.Size = new System.Drawing.Size(162, 20);
            this.searchBalanceTextBox.TabIndex = 7;
            this.searchBalanceTextBox.TextChanged += new System.EventHandler(this.searchBalanceTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search By";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox accountBranchTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox balanceAccNumberTextBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchBalanceTextBox;
        private System.Windows.Forms.ListView showListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label CommendLabel;
        private System.Windows.Forms.RadioButton accNumberRadioButton;
        private System.Windows.Forms.RadioButton branchRadioButton;
        private System.Windows.Forms.RadioButton accNameRadioButton;
    }
}


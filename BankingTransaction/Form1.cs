using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingTransaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string connectionString = ConfigurationManager.ConnectionStrings["BankTransetionConnString"].ConnectionString;

        private bool isUpdateMode = false;
        private int accNumber;
        

        private void saveButton_Click(object sender, EventArgs e)
        {
            BankAccount newAccount = new BankAccount();
            newAccount.accountNumber = int.Parse(accountNumberTextBox.Text);
            newAccount.accountName = accountNameTextBox.Text;
            newAccount.accountBranch = accountBranchTextBox.Text;
            newAccount.accountBalance = 0;

            if (isUpdateMode)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string insertQuery = "UPDATE bankAccountTable SET AccName='" + newAccount.accountName + "',AccBranch='" + newAccount.accountBranch + "'  WHERE AccNumber='" + accNumber + "'";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowAffected > 0)
                {
                    MessageBox.Show(@"Account Successfully Update.");
                    isUpdateMode = false;
                    saveButton.Text = "Save";
                    accNumber = 0;
                    accountNumberTextBox.ReadOnly = false;
                    accountNumberTextBox.Clear();
                    accountNameTextBox.Clear();
                    accountBranchTextBox.Clear();
                    ShowAllAccount();
                }
                else
                {
                    MessageBox.Show(@"Update Failed.");
                }
            }
            else
            {
                if (accountNumberTextBox.Text != "" && accountNameTextBox.Text != "" && accountBranchTextBox.Text != "")
                {
                    
                    if (newAccount.accountNumber.ToString().Length >= 5)
                    {
                        if (IsAccountNumberExists(newAccount.accountNumber))
                        {
                            MessageBox.Show(@"Account Number already exists.");
                            return;
                        }
                        SqlConnection connection = new SqlConnection(connectionString);

                        string insertQuery = "INSERT INTO bankAccountTable VALUES('" + newAccount.accountNumber + "','" + newAccount.accountName + "','" + newAccount.accountBranch + "','" + newAccount.accountBalance + "')";
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        connection.Close();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show(@"Account Successfully created.");
                            accountNumberTextBox.Clear();
                            accountNameTextBox.Clear();
                            accountBranchTextBox.Clear();
                            ShowAllAccount();
                        }
                        else
                        {
                            MessageBox.Show(@"Account creation Failed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Account Number must be 5 disite.");
                    }
                }
                else
                {
                    MessageBox.Show(@"Fill up requirement");
                }
            }
            
            
        }

        public bool IsAccountNumberExists(int accNumber)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string insertQuery = "SELECT * FROM bankAccountTable WHERE AccNumber='"+accNumber+"'";
            SqlCommand command = new SqlCommand(insertQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            bool isAccountNumberExists = false;
            while (reader.Read())
            {
                isAccountNumberExists = true;
            }
            connection.Close();
            return isAccountNumberExists;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (balanceTextBox.Text!="" && balanceAccNumberTextBox.Text!="")
            {
                
                int accNumber = int.Parse(balanceAccNumberTextBox.Text);
                double deposit = Convert.ToDouble(balanceTextBox.Text);
                double balance = GetBalanceByAccount(accNumber);
                double totalBalance = (balance + deposit);

                if (IsAccountNumberExists(accNumber)==false)
                {
                    MessageBox.Show(@"Account Number does not match.");
                }
                else
                {
                    if (deposit>0)
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        string insertQuery = "UPDATE bankAccountTable SET AccBalance='" + totalBalance + "' WHERE AccNumber='" + accNumber + "'";
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        connection.Close();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show(@"Successfully Deposit :" + deposit + @" Taka and Balance : " + totalBalance + @" Taka");
                            balanceTextBox.Clear();
                            balanceAccNumberTextBox.Clear();
                            ShowAllAccount();
                        }
                        else
                        {
                            MessageBox.Show(@"Operation Failed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Invalide Input");
                    }
                    
                }
 
            }
            else
            {
                MessageBox.Show(@"Please enter Account Number & Balance");
            }
        }

        public double GetBalanceByAccount(int accNumber)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string insertQuery = "SELECT * FROM bankAccountTable WHERE AccNumber='" + accNumber + "'";
            SqlCommand command = new SqlCommand(insertQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<BankAccount> accountList = new List<BankAccount>();
            while (reader.Read())
            {
                BankAccount account = new BankAccount();
                account.id = int.Parse(reader["ID"].ToString());
                account.accountNumber = int.Parse(reader["AccNumber"].ToString());
                account.accountName = reader["AccName"].ToString();
                account.accountBranch = reader["AccBranch"].ToString();
                account.accountBalance = double.Parse(reader["AccBalance"].ToString());
                accountList.Add(account);
            }
            reader.Close();
            connection.Close();

            double totalBalance=0;
            foreach (var bankAccount in accountList)
            {
                totalBalance = bankAccount.accountBalance;
            }

            return totalBalance;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (balanceTextBox.Text != "" && balanceAccNumberTextBox.Text != "")
            {

                int accNumber = int.Parse(balanceAccNumberTextBox.Text);
                double withdraw = Convert.ToDouble(balanceTextBox.Text);
                double balance = GetBalanceByAccount(accNumber);
                double totalBalance = (balance - withdraw);

                if (IsAccountNumberExists(accNumber) == false)
                {
                    MessageBox.Show(@"Account Number does not match.");
                }
                else
                {
                    if (balance>0)
                    {
                        if (withdraw>0)
                        {
                            SqlConnection connection = new SqlConnection(connectionString);
                            string insertQuery = "UPDATE bankAccountTable SET AccBalance='" + totalBalance + "' WHERE AccNumber='" + accNumber + "'";
                            SqlCommand command = new SqlCommand(insertQuery, connection);
                            connection.Open();
                            int rowAffected = command.ExecuteNonQuery();
                            connection.Close();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show(@"Successfully Withdraw :" + withdraw + @" Taka and Balance : " + totalBalance + @" Taka");
                                balanceTextBox.Clear();
                                balanceAccNumberTextBox.Clear();
                                ShowAllAccount();
                            }
                            else
                            {
                                MessageBox.Show(@"Operation Failed.");
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Invalide Input.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Sorry ther are no balance in your account.");
                    }
                }

            }
            else
            {
                MessageBox.Show(@"Please enter Account Number & Balance");
            }
        }
        private void searchBalanceTextBox_TextChanged(object sender, EventArgs e)
        {
                string search = searchBalanceTextBox.Text;


                SqlConnection connection = new SqlConnection(connectionString);
                string insertQuery = null;
                if (accNumberRadioButton.Checked)
                {
                    insertQuery = "SELECT * FROM bankAccountTable WHERE AccNumber LIKE'%" + search + "%'";
                    CommendLabel.Text = @"Enter Account Number Only";
                }
                else if (accNameRadioButton.Checked)
                {
                    insertQuery = "SELECT * FROM bankAccountTable WHERE AccName LIKE'%" + search + "%'";
                    CommendLabel.Text = @"Enter Account Name Only";
                }
                else if (branchRadioButton.Checked)
                {
                    insertQuery = "SELECT * FROM bankAccountTable WHERE AccBranch LIKE'%" + search + "%'";
                    CommendLabel.Text = @"Enter Branch Name Only";
                }
                SqlCommand command = new SqlCommand(insertQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<BankAccount> accountList = new List<BankAccount>();
                while (reader.Read())
                {
                    BankAccount account = new BankAccount();
                    account.id = int.Parse(reader["ID"].ToString());
                    account.accountNumber = int.Parse(reader["AccNumber"].ToString());
                    account.accountName = reader["AccName"].ToString();
                    account.accountBranch = reader["AccBranch"].ToString();
                    account.accountBalance = double.Parse(reader["AccBalance"].ToString());
                    accountList.Add(account);
                }
                reader.Close();
                connection.Close();
                LoadAllBankAccount(accountList);
          
        }

        public void LoadAllBankAccount(List<BankAccount> accounts)
        {
            int i = 0;
            showListView.Items.Clear();
            foreach (var bankAccount in accounts)
            {
                i++;
                ListViewItem item = new ListViewItem(bankAccount.id.ToString());
                item.SubItems.Add(i.ToString());
                item.SubItems.Add(bankAccount.accountNumber.ToString());
                item.SubItems.Add(bankAccount.accountName);
                item.SubItems.Add(bankAccount.accountBranch);
                item.SubItems.Add(bankAccount.accountBalance.ToString());
                showListView.Items.Add(item);
            }
        }

        private void showListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = showListView.SelectedItems[0];

            int id = int.Parse(item.Text.ToString());
            BankAccount account = GetById(id);
            if (account!=null)
            {
                isUpdateMode = true;
                saveButton.Text =@"Update";
                accountNumberTextBox.ReadOnly = true;
                accNumber = account.accountNumber;

                accountNumberTextBox.Text = Convert.ToString(account.accountNumber);
                accountNameTextBox.Text = account.accountName;
                accountBranchTextBox.Text = account.accountBranch;

            }
        }

        public BankAccount GetById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string insertQuery = "SELECT * FROM bankAccountTable WHERE ID='" + id + "'";
            SqlCommand command = new SqlCommand(insertQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<BankAccount> accountList = new List<BankAccount>();
            while (reader.Read())
            {
                BankAccount account = new BankAccount();
                account.id = int.Parse(reader["ID"].ToString());
                account.accountNumber = int.Parse(reader["AccNumber"].ToString());
                account.accountName = reader["AccName"].ToString();
                account.accountBranch = reader["AccBranch"].ToString();
                account.accountBalance = double.Parse(reader["AccBalance"].ToString());
                accountList.Add(account);
            }
            reader.Close();
            connection.Close();
            return accountList.FirstOrDefault();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllAccount();
        }

        public void ShowAllAccount()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            String insertQuery = "SELECT * FROM bankAccountTable ";
            SqlCommand command = new SqlCommand(insertQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<BankAccount> accountList = new List<BankAccount>();
            while (reader.Read())
            {
                BankAccount account = new BankAccount();
                account.id = int.Parse(reader["ID"].ToString());
                account.accountNumber = int.Parse(reader["AccNumber"].ToString());
                account.accountName = reader["AccName"].ToString();
                account.accountBranch = reader["AccBranch"].ToString();
                account.accountBalance = double.Parse(reader["AccBalance"].ToString());
                accountList.Add(account);
            }
            reader.Close();
            connection.Close();
            LoadAllBankAccount(accountList);
        }
    }
}

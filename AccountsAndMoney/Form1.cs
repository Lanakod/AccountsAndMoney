using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsAndMoney
{
    public partial class Form1 : Form
    {
        Account[] accounts = new Account[0];
        string[] AccountList = new string[0];
        string[] AccountListSend = new string[0];
        int LastId = 1;
        int currentAccount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_CreateAccount_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{1,9}");
            MatchCollection match = regex.Matches(textBox_createAccount.Text);
            if (match.Count > 0)
            {
                Array.Resize(ref accounts, accounts.Length + 1);
                Array.Resize(ref AccountList, AccountList.Length + 1);
                Array.Resize(ref AccountListSend, AccountListSend.Length + 1);

                accounts[accounts.Length - 1] = new Account(int.Parse(textBox_createAccount.Text), LastId, Messager);
                
                AccountList[AccountList.Length - 1] = $"Счёт №{LastId}";
                comboBox1.DataSource = AccountList;

                AccountListSend[AccountListSend.Length - 1] = $"Счёт №{LastId}";
                comboBox_Send.DataSource = AccountListSend;
                LastId += 1;
            }
            else textBox_createAccount.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentAccount = comboBox1.SelectedIndex;
            textBox_Current.Text = accounts[currentAccount].CurrentSum.ToString();
            textBox_Put.Text = ""; textBox_Send.Text = ""; textBox_WD.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{1,9}");
            MatchCollection match = regex.Matches(textBox_Put.Text);
            if (match.Count > 0)
            {
                accounts[currentAccount].Put(int.Parse(textBox_Put.Text));
                textBox_Current.Text = accounts[currentAccount].CurrentSum.ToString();
            }
            else textBox_Put.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{1,9}");
            MatchCollection match = regex.Matches(textBox_WD.Text);
            if (match.Count > 0)
            {
                accounts[currentAccount].Withdraw(int.Parse(textBox_WD.Text));
                textBox_Current.Text = accounts[currentAccount].CurrentSum.ToString();
            }
            else textBox_WD.Text = "";
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[0-9]{1,9}");
            MatchCollection match = regex.Matches(textBox_Send.Text);
            if (match.Count > 0)
            {
                if (comboBox_Send.SelectedIndex != comboBox1.SelectedIndex)
                {
                    if (Messager($"Вы точно хотите перевести {textBox_Send.Text} на счёт №{accounts[comboBox_Send.SelectedIndex].AccountID}", "Уведомление", MessageBoxIcon.Question, MessageBoxButtons.YesNo))
                    {
                        accounts[currentAccount].Send(int.Parse(textBox_Send.Text), accounts[comboBox_Send.SelectedIndex]);
                        textBox_Current.Text = accounts[currentAccount].CurrentSum.ToString();
                    }
                }
                else Messager($"Нельзя перевести средства на свой же счёт", "Ошибка", MessageBoxIcon.Error);
            }
            else textBox_Send.Text = "";
        }
        public static bool Messager(string Message, string Title, MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            DialogResult result = MessageBox.Show(Message, Title, buttons, icon);
            if(buttons == MessageBoxButtons.YesNo)
                if (result == DialogResult.Yes) return true;
            return false;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if(accounts.Length != 0)
            {
                if (Messager($"Вы точно хотите удалить счёт №{accounts[currentAccount].AccountID}", "Уведомление", MessageBoxIcon.Question, MessageBoxButtons.YesNo))
                {
                    int deletedAccountId = accounts[currentAccount].AccountID;
                    accounts[currentAccount] = null;
                    AccountList[currentAccount] = null;
                    AccountListSend[currentAccount] = null;

                    for (int i = currentAccount; i < accounts.Length; i++)
                    {
                        if (i < accounts.Length - 1)
                        {
                            accounts[i] = accounts[i + 1];
                            AccountList[i] = AccountList[i + 1];
                            AccountListSend[i] = AccountListSend[i + 1];
                        }

                        Array.Resize(ref accounts, accounts.Length - 1);
                        Array.Resize(ref AccountList, AccountList.Length - 1);
                        Array.Resize(ref AccountListSend, AccountListSend.Length - 1);

                        Messager($"Вы удалили счёт №{deletedAccountId}", "Уведомление", MessageBoxIcon.Warning);

                        comboBox1.DataSource = AccountList;
                        comboBox_Send.DataSource = AccountListSend;
                    }
                }
            }
        }
    }
}

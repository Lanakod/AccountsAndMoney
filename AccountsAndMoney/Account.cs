using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsAndMoney
{
    class Account
    {
        public delegate void AccountStateHandler(string Message, string Title, MessageBoxIcon Icon);
        AccountStateHandler _delegate;
        int _sum;
        public int CurrentSum { get { return _sum; } }
        public int AccountID { get; }
        public void RegisterHandler(AccountStateHandler Delegate)
        {
            _delegate += Delegate;
        }
        public Account(int Amount, int accountID, AccountStateHandler Delegate = null)
        {
            _sum = Amount;
            _delegate += Delegate;
            AccountID = accountID;
            if (_delegate != null) _delegate($"Открыт счет №{AccountID} с суммой {Amount}", "Открытие счёта", MessageBoxIcon.Information);
        }
        public void Put(int Amount)
        {
            _sum += Amount;
            if (_delegate != null) _delegate($"Сумма {Amount} положена на счёт №{AccountID}", "Пополнение счёта", MessageBoxIcon.Information);
        }
        public void Send(int Amount, Account account)
        {
            if (Amount <= _sum)
            {
                _sum -= Amount;
                account.Put(Amount);
                if (_delegate != null) _delegate($"Сумма {Amount} переведена с счёта №{AccountID} на счет №{account.AccountID}, осталось {_sum}", "Перевод с счёта", MessageBoxIcon.Warning);
            }
            else if (_delegate != null) _delegate($"Недостаточно средств на счете №{account.AccountID}", "Ошибка", MessageBoxIcon.Error);
        }
        public void Withdraw(int Amount)
        {
            if (Amount <= _sum)
            {
                _sum -= Amount;
                if (_delegate != null) _delegate($"Сумма {Amount} снята с счета №{AccountID}, осталось {_sum}", "Снятие с счёта", MessageBoxIcon.Warning);
            }
            else if (_delegate != null) _delegate($"Недостаточно средств на счете №{AccountID}", "Ошибка", MessageBoxIcon.Error);
        }
        public void UnregisterHandler(AccountStateHandler Delegate)
        {
            _delegate -= Delegate;
        }
    }
}

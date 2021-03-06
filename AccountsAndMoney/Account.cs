﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsAndMoney
{
    class Account
    {
        public delegate bool AccountStateHandler(string Message, string Title, MessageBoxIcon Icon, MessageBoxButtons Buttons);
        AccountStateHandler _delegate;
        int _sum;
        public int CurrentSum { get { return _sum; } }
        public int AccountID { get; }
        public void RegisterHandler(AccountStateHandler Delegate) => _delegate += Delegate;
        public Account(int Amount, int accountID, AccountStateHandler Delegate = null)
        {
            _sum = Amount;
            _delegate += Delegate;
            AccountID = accountID;
           _delegate?.Invoke($"Открыт счет №{AccountID} с суммой {Amount}", "Открытие счёта", MessageBoxIcon.Information, MessageBoxButtons.OK);
        }
        public void Put(int Amount)
        {
            _sum += Amount;
            _delegate?.Invoke($"Сумма {Amount} положена на счёт №{AccountID}", "Пополнение счёта", MessageBoxIcon.Information, MessageBoxButtons.OK);
        }
        public void Send(int Amount, Account account)
        {
            if (Amount <= _sum)
            {
                _sum -= Amount;
                _delegate?.Invoke($"Сумма {Amount} переведена с счёта №{AccountID} на счет №{account.AccountID}, осталось {_sum}", "Перевод с счёта", MessageBoxIcon.Warning, MessageBoxButtons.OK);
                account.Put(Amount);
            }
            else _delegate?.Invoke($"Недостаточно средств на счете №{AccountID}", "Ошибка", MessageBoxIcon.Error, MessageBoxButtons.OK);
        }
        public void Withdraw(int Amount)
        {
            if (Amount <= _sum)
            {
                _sum -= Amount;
                _delegate?.Invoke($"Сумма {Amount} снята с счета №{AccountID}, осталось {_sum}", "Снятие с счёта", MessageBoxIcon.Warning, MessageBoxButtons.OK);
            }
            else _delegate?.Invoke($"Недостаточно средств на счете №{AccountID}", "Ошибка", MessageBoxIcon.Error, MessageBoxButtons.OK);
        }
        public void UnregisterHandler(AccountStateHandler Delegate) => _delegate -= Delegate;
    }
}

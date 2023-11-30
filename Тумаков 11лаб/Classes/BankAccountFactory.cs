using System.Collections.Generic;

namespace Тумаков_11лаб
{
    public class BankAccountFactory
    {
        private Dictionary<int, BankAccount> accounts; 
        /// <summary>
        /// Хеш-таблица для хранения банковских счетов
        /// </summary>
        public BankAccountFactory()
        {
            accounts = new Dictionary<int, BankAccount>();
        }

        public int CreateAccount(string ownerName, decimal initialBalance)
        {
            BankAccount account = new BankAccount(ownerName, initialBalance);
            /// <summary>
            /// Создаем новый объект банковского счета
            /// </summary>
            int accountNumber = account.AccountNumber;
            /// <summary>
            ///Получаем номер созданного счета
            /// </summary>
            accounts.Add(accountNumber, account); 
            /// <summary>
            /// Добавляем счет в хеш-таблцу
            /// </summary>

            return accountNumber;
            /// <summary>
            /// Возвращаем номер созданного счета
            /// </summary>
            /// Возвращаем номер созданного счета
        }

        public void CloseAccount(int accountNumber)
        {
            accounts.Remove(accountNumber);
            /// <summary>
            /// Удаляем счет из хеш-таблицы
            /// </summary>
        }
    }
}

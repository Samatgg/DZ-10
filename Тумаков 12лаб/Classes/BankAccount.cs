
namespace Тумаков_11лаб
{
    public class BankAccount
    {
        private static int nextAccountNumber = 1;

        public int AccountNumber { get; }
        public string OwnerName { get; }
        public decimal Balance { get; private set; }

        internal BankAccount(string ownerName, decimal initialBalance)
        {
            AccountNumber = nextAccountNumber++;
            OwnerName = ownerName;
            Balance = initialBalance;
        }
        public static bool operator ==(BankAccount account1, BankAccount account2)
        {
            if (ReferenceEquals(account1, account2))
            {
                return true;
            }

            if (ReferenceEquals(account1, null) || ReferenceEquals(account2, null))
            {
                return false;
            }

            return account1.AccountNumber == account2.AccountNumber;
        }
        public static bool operator !=(BankAccount account1, BankAccount account2)
        {
            return !(account1 == account2);
        }
        /// <summary>
        /// Переопределение операторов `==` и `!=`
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(null, obj) || !(obj is BankAccount))
            {
                return false;
            }

            return Equals((BankAccount)obj);
        }
        public bool Equals(BankAccount other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return AccountNumber == other.AccountNumber;
        }
        /// <summary>
        /// Переопределение метода `Equals`
        /// </summary>
        public override int GetHashCode()
        {
            return AccountNumber.GetHashCode();
        }
        /// <summary>
        /// Переопределениe метода `GetHashCode`
        /// </summary>
        public override string ToString()
        {
            return $"Номер счета: {AccountNumber}, Владелец: {OwnerName}, Баланс: {Balance}";
        }
        /// <summary>
        /// Переопределение метода `ToString`
        /// </summary>

    }
}

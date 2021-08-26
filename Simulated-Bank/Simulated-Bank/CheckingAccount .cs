using System;


namespace ByteBank
{
    public class CheckingAccount 
    {
        private Client holder;
        private int _number;
        private int _agency;
        private double _balance;

        public static int TotalAccountsCreated { get; private set; }

        public CheckingAccount(int agency, int number)
        {
            Agency = agency;
            Number = number;

            TotalAccountsCreated++;
        }

        public int Agency
        {
            get
            {
                return _agency;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

                _agency = value;
            }
        }

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

                _number = value;
            }
        }

        public Client Holder
        { get; set; }

        public double Balance
        {

            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this._balance = value;
            }

        }

        public bool ToWithdraw(double _value)
        {
            if (_balance < _value)
            {
                return false;
            }

            _balance -= _value;
            return true;

        }

        public void Deposit (double _value)
        {
            _balance += _value;
        }

        public bool Transfer (double _value, CheckingAccount  otherAccount)
        {
            if (_balance < _value)
            {
                return false;
            }

            _balance -= _value;
            otherAccount.Deposit(_value);
            return true;

        }

    }

}

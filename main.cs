using System;
class Program
{
    public class Array
    {
        public int _creditAmount;
        public double _interestRate;
        public double _monthlyFee;
        public int _billingPeriod;
        public double _fullAmount;

        public int CreditAmount
        {
            get { return _creditAmount; }
            set { _creditAmount = value; }
        }
        public int BillingPeriod
        {
            get { return _billingPeriod; }
            set { _billingPeriod = value; }
        }
        public void CalculateMonthlyFee()
        {
            _billingPeriod = Convert.ToInt32(Console.ReadLine());
            int Days = _billingPeriod * 365;
            double Daily = _fullAmount / Days;
            _monthlyFee = Daily*31;
            Console.WriteLine("в месяц вы должны платить: " + _monthlyFee + " рублей.");
        }
        public void CalculateFullAmount()
        {
            _creditAmount = Convert.ToInt32(Console.ReadLine());
            double Percent = _creditAmount / 100;
            var interestRateAmount = Percent * _interestRate;
            _fullAmount = _creditAmount + interestRateAmount;
            Console.WriteLine("полная сумма кредита с процентами: " + _fullAmount);
        }
    }
    public class Person : Array
    {
        double _interestRate = 15;
        public int _inCome;
        public int _expenses;
        public int _remain;
        public int InCome
        {
            get { return _inCome; }
            set { _inCome = value; }
        }
        public int Expenses
        {
            get { return _expenses; }
            set { _expenses = value; }
        }
        public void Remains()
        {
            Console.WriteLine("Каков ваш заработок в месяц?");
            _inCome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Каковы ваши траты в месяц?");
            _expenses = Convert.ToInt32(Console.ReadLine());
            int _remain = _inCome - _expenses;
        }
    }
    public class Pensioner : Person
    {
        public double _interestRate = 10;
    }

    public class Parent : Person
    {
        public double _interesRate = 13;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("кем вы являетесь? пенсионер - 1, родитель или опекун - 2, никто из перечисленных - 3");
        int Answer = Convert.ToInt32(Console.ReadLine());
        if (Answer == 1)
        {
            Pensioner credit = new Pensioner();
            Console.WriteLine("На сколько рублей вы хотите взять кредит?");
            credit.CalculateFullAmount();
            Console.WriteLine("На сколько лет вы хотите взять кредит?");
            credit.CalculateMonthlyFee();
            credit.Remains();
            for (int i = 0; i < 1; i++)
            {
                if (credit._remain < credit._monthlyFee)
                {
                    Console.WriteLine("кредит не одобрен");
                    break;
                }
                else
                {
                    Console.WriteLine("кредит одобрен");
                }
            }
        }
        if (Answer == 2)
        {
            Parent credit = new Parent();
            Console.WriteLine("На сколько рублей вы хотите взять кредит?");
            credit.CalculateFullAmount();
            Console.WriteLine("На сколько лет вы хотите взять кредит?");
            credit.CalculateMonthlyFee();
            credit.Remains();
            for (int i = 0; i < 1; i++)
            {
                if (credit._remain < credit._monthlyFee)
                {
                    Console.WriteLine("кредит не одобрен");
                    break;
                }
                else
                {
                    Console.WriteLine("кредит одобрен");
                }
            }
        }
        else if (Answer == 3)
        {
            Person credit = new Person();
            Console.WriteLine("На сколько рублей вы хотите взять кредит?");
            credit.CalculateFullAmount();
            Console.WriteLine("На сколько лет вы хотите взять кредит?");
            credit.CalculateMonthlyFee();
            credit.Remains();
            for (int i = 0; i < 1; i++)
            {
                if (credit._remain < credit._monthlyFee)
                {
                    Console.WriteLine("кредит не одобрен");
                    break;
                }
                else if (credit._remain >= credit._monthlyFee)
                {
                    Console.WriteLine("кредит одобрен");
                }
            }
        }
    }
}
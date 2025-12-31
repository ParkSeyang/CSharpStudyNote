using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNote
{
    internal class AbstractionNote
    {
        protected abstract class AbstractStudy
        {
            private string bankName;
            private int money;
            private Dictionary<string, int> passBook = new Dictionary<string, int>();
            private Queue<string> waitingGuestList = new Queue<string>();

            protected AbstractStudy(string bankname, int cash, Queue<string> List, Dictionary<string, int> passbook)
            {
                bankName = bankname;
                money = cash;
                waitingGuestList = List;
                passBook = passbook;
            }

            protected string BankName { get { return bankName; } set { bankName = value; } }
            protected int Money { get { return money; } set { money = value; } } 


            protected abstract void DepositMoney();

            protected abstract void withdrawMoney();
            protected abstract void GuestList();

            protected void BalancePassBook(string name,int money, Dictionary<string, int> passbook)
            {
                int balance = 0;
                if (passbook.ContainsKey(name) == true)
                {
                    Console.WriteLine($"현재 {name}님의 남은 잔돈 은 '{passbook.TryGetValue(name, out balance)}' 입니다.");
                }
                else
                {
                    Console.WriteLine(" 고객님의 통장에 등록된 이름과 일치하지 않습니다. ");
                }
            }


            protected virtual void Event()
            {
                
            }


        }

        protected class Bank1 : AbstractStudy
        {

             protected Bank1(string bankname, int cash, Queue<string> List, Dictionary<string, int> passbook) : base(bankname, cash, List, passbook)
             {
                
             }


            protected override void DepositMoney()
            {
            
            }

            protected override void withdrawMoney()
            {
                
            }


            protected override void GuestList()
            {
                
            }

            

        }


    }
}

using LuckySteps_2_Gurgen_.Log;
using System;
using System.Collections.Generic;

namespace LuckySteps_2_Gurgen_
{
    class Games : IGames
    {
        public User _User { get; set; }
        public Ticket _Ticket { get; set; }
        public int Step { get; set; }
        Dictionary<char, Func<int, int>> choseDictionary;
        Func<int, int> choseR;
        Func<int, int> choseL;

        public Games()
        {
            choseDictionary = new Dictionary<char, Func<int, int>>();
            _User = new User();
            _Ticket = new Ticket(10, 200);
            Step = 1;
            choseL = GetLeftTableAmount;
            choseR = GetRightTableAmount;
            choseDictionary.Add('L', choseL);
            choseDictionary.Add('R', choseR);
        }
        public void StartGame()
        {
            _Ticket.Create(new DoubleAmountTicketCreater());
            new ShowInfo().PrintTable(_Ticket.AllTables);
            Registration.UserRegistration(_User);
            for (int i = 0; i < 10; i++)
            {
                Information.ChooseInformation(Step);
                char choose = Convert.ToChar(Console.ReadLine());
                Validation.ChooseValidation(choose);
                if (choose == 'S')
                {
                    Console.WriteLine("congratulations you won \n" + "WonAmount=" + _User.WonAmount);
                    break;
                }
                _User.Amount = choseDictionary[choose].Invoke(i);
                Step++;
                if (_User.Amount != 0)
                {
                    _User.WonAmount += _User.Amount;

                    Console.WriteLine("The answer is correct\n" + "Amount=" + _User.Amount + "\nWonAmount=" + _User.WonAmount);
                }
                else { _User.WonAmount = 0; Console.WriteLine("The answer is not correct WonAmount=" + _User.WonAmount); break; }
            }
            new Loger().LogInformation("Username=" + _User.FullName + "WonAmount=" + _User.WonAmount);
            Console.WriteLine("Your Ticket is:");
            new ShowInfo().PrintTable(_Ticket.AllTables);
        }
        public int GetLeftTableAmount(int step)
        {
            return _Ticket.LeftTable[step];
        }
        public int GetRightTableAmount(int step)
        {
            return _Ticket.RightTable[step];
        }

    }
}

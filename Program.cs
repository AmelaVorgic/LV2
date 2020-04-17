using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*zadatak 1.,2.*/
            DiceRoller diceRoller = new DiceRoller();
            const int numberOfDice = 20;
            for (int i = 0; i < numberOfDice; i++)
            {
                diceRoller.InsertDie(new Die(6));
            }
            diceRoller.RollAllDice();
            IList<int> results = diceRoller.GetRollingResults();
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
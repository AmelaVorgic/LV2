using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    /*zadatak 6.*/
    class FlexibleDiceRoller : IRoller, IHandleDice
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        /*zadatak 7.*/
        public void RemoveDiceWithSides(int sides)
        {
            for (int i = 0; i < dice.Count; i++)
            {
                if (dice[i].NumberOfSides == sides)
                {
                    dice.RemoveAt(i);

                    --i;
                }
            }
        }
    }
}

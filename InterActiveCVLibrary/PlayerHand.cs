using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveCVLibrary
{
    public class PlayerHand
    {
        public ICard[] Cards = new ICard[3];
        public Queue<ICard> CardsInDrawPile;
        
        public PlayerHand()
        {
            Cards[0] = new CardRequestHardSkills();
        }

        public ICard GetCard(string name)
        {
            if(int.TryParse(name, out int id))
            {
                if (id >= Cards.Length)
                    return null;

                return Cards[id];
            }
            return Cards.First();
            
        }

        public void RefillHand()
        {
           // Cards.Append(CardsInDrawPile.Dequeue());
        }

    }
}

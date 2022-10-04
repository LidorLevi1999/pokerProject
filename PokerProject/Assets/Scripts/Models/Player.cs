using DefaultNamespace;
using Managers;

namespace Models
{
    public class Player : IPlayer
    {
        public Card Card1;
        public Card Card2;

        public Player()
        {
            this.Card1 = GameManager.Instance.CurrentDeck.Pop();
            this.Card2 = GameManager.Instance.CurrentDeck.Pop();
        }

        public void Bet()
        {
            throw new System.NotImplementedException();
        }

        public void Call()
        {
            // TODO : IMPLEMENT
        }

        public void Check()
        {
            // TODO : IMPLEMENT
        }

        public void Raise()
        {
            // TODO : IMPLEMENT
        }

        public void ReRaise()
        {
            // TODO : IMPLEMENT
        }

        public void Fold()
        {
            // TODO : IMPLEMENT
        }
    }
}
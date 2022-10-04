using System.Collections.Generic;
using System.Linq;
using Enums;
using Models;
using UnityEngine;
using Random = System.Random;

namespace Managers
{
    internal class GameManager : MonoBehaviour
    {
        internal static GameManager Instance;
        public List<Card> CardsGeneralDeck = new List<Card>();
        public Stack<Card> CurrentDeck = new Stack<Card>();
        public int Rivals;
        public List<Player> PlayersList;
        void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            CreateDesk();
        }

        private void CreateDesk()
        {
            for (int i = 0; i < 13; i++)
            {
                CardsGeneralDeck.Add(new Card(i+1,Shape.Spade, "black"));
                CardsGeneralDeck.Add(new Card(i+1,Shape.Club , "black"));
                CardsGeneralDeck.Add(new Card(i+1,Shape.Heart , "red"));
                CardsGeneralDeck.Add(new Card(i+1,Shape.Diamond , "red"));
            }
            ShuffleList(ref CardsGeneralDeck);
        }

        private void ShuffleList(ref List<Card> deck)
        {
            Random rnd = new Random();
            deck = deck.OrderBy(item => rnd.Next()).ToList();
            AssignCurrentDeck();
        }

        private void AssignCurrentDeck()
        {
            CurrentDeck.Clear();
            CardsGeneralDeck.ForEach(card => CurrentDeck.Push(card));
        }
        void Update()
        {
        }
    }
}

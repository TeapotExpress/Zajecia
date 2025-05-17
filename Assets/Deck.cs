using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem.Switch;
using System.Collections.Generic;
using TMPro;

public class Deck : MonoBehaviour
{
    private TMP_Text text;
    public List<Card> deck = new List<Card>();
    string[] suits = { "Spade", "Club", "Heart", "Diamond" };
    string[] ranks = { "Ace", "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2" };


    public void Start()
    {
        text = GetComponent<TMP_Text>();
        foreach (string suit in suits)
        {
            foreach(string rank in ranks)
            {
                deck.Add(Card.CreateInstance(rank, suit));
            }
        }
        UpdateText();
    }

    public void UpdateText()
    {
        text.text = "Cards in deck: " + deck.Count.ToString();
    }
}

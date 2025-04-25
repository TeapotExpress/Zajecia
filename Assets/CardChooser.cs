using Unity.VisualScripting;
using UnityEngine;

public class CardChooser : MonoBehaviour
{
    public int currentCard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private cardObject[] cards;
    void Start()
    {
        cards = GetComponentsInChildren<cardObject>();
        ChoseACard();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space")) ChoseACard();
    }

    public void ChoseACard()
    {
        foreach (cardObject card in cards)
        {
            card.onUnchosen();
        }
        int newCard = Random.Range(0, cards.Length);
        while (newCard == currentCard) newCard = Random.Range(0, cards.Length);
        currentCard = newCard;
        cards[currentCard].onChosen();
    }
}

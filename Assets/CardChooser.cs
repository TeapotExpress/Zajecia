using Unity.VisualScripting;
using UnityEngine;

public class CardChooser : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private Deck deckRef;

    public void ChoseACard()
    {
        int index = Random.Range(0, deckRef.deck.Count);
        Card pickedCard = deckRef.deck[index];
        deckRef.deck.Remove(pickedCard);
        deckRef.UpdateText();
        gameObject.GetComponent<cardObject>().myCard = pickedCard;
        gameObject.GetComponent<cardObject>().refreshDisplayValues();

    }

    private void Update()
    {
        if (Input.GetKeyDown("space")) ChoseACard();
    }
}

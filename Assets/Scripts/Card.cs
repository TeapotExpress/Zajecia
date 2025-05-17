using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Scriptable Objects/Card")]
public class Card : ScriptableObject
{
    public string rank;
    public string suit;
    public int value;

    public void Init(string rank, string suit)
    {
        this.rank = rank;
        this.suit = suit;
    }

    public static Card CreateInstance(string rank, string suit)
    {
        var currentCard = ScriptableObject.CreateInstance<Card>();
        currentCard.Init(rank, suit);
        return currentCard;
    }
    public void WhoAmI()
    {
        Debug.Log("Hi! I'm " + rank + " of " + rank + "s");
    }

    public string MyText()
    {
        return (rank + " of " + suit + "s");
    }
}

using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Scriptable Objects/Card")]
public class Card : ScriptableObject
{
    public string rank= "";
    public string suit = "";
    public int value;



    public void WhoAmI()
    {
        Debug.Log("Hi! I'm " + rank + " of " + rank + "s");
    }

    public string MyText()
    {
        return (rank + " of " + suit + "s");
    }
}

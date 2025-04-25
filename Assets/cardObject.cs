using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class cardObject : MonoBehaviour
{

    public Card myCard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        refreshDisplayValues();
    }

    void refreshDisplayValues()
    {
        gameObject.GetComponentInChildren<TMP_Text>().text = myCard.MyText();
    }

    public void onChosen()
    {
        transform.localScale = new Vector3(2f, 2f, 1f);
    }

    public void onUnchosen()
    {
        transform.localScale = Vector3.one;
    }
}

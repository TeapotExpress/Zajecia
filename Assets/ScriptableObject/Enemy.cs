using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Scriptable Objects/Enemy")]
public class Enemy : ScriptableObject
{
    public float hp = 10;
    public string en_name = "Dark souls3";

    public void Attack()
    {
        Debug.Log("Skibidi");
    }
}

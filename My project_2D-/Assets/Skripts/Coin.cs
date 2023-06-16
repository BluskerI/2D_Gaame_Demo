using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public int coin;

    public Text text;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Coin")
        {
            coin = coin + 1;
            Destroy(collider.gameObject);
            text.text = coin.ToString();
        }
    }

 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public int coins;
    public Text TextCoins;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Money")
        {
            coins++;
            other.gameObject.SetActive(false);
            TextCoins.text = coins.ToString();
        }
    }
    void Update()
    {
        
    }
}

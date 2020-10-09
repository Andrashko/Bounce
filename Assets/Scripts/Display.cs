using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    // Start is called before the first frame update

    public Text coinsText;
    public Text livesText;

    public GameObject messageText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins: " + Storage.Coins.ToString();
        livesText.text = "Lives:" + Storage.Lives.ToString();
        if (Storage.GameOver) 
        {
            (messageText).SetActive(true);
        }
    }
}

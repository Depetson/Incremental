using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update

    public int gold = 0;

    public TMP_Text goldText;
    public Hajsorob hajsorob;

    void Start()
    {
        goldText.text = $"Hajsiwo: {gold}$";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddGold(int amount)
    {
        gold += amount;
        goldText.text = $"Hajsiwo: {gold}$";
    }

    public void BuyManager()
    {
        if (gold >= 100)
        {
            hajsorob.BuyManager();
            gold -= 100;
        }
    }
}

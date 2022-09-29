using Assets;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hajsorob : MonoBehaviour
{
    Main mainScript;
    public Image progressBar;
    public float delay = 2f;
    public bool clicked = false;
    
    public TMP_Text amountText;
    public TMP_Text priceText;
    public TMP_Text earnAmountText;
    public TMP_Text nameText;

    public int price = 3;
    public int earnAmount = 1;
    public int amount = 1;

    public bool hasManager = false;

    public List<int> bonuses = new List<int>();

    public HajsorobBase data;
    // Start is called before the first frame update
    void Start()
    {
        mainScript = Camera.main.GetComponent<Main>();
      //  mainScript.hajsorob = this;
        priceText.text = $"{price}$";
        earnAmountText.text = $"{CalculateEarnAmount()}$";
    }

    // Update is called once per frame
    void Update()
    {
        if (hasManager || clicked)
        {
            progressBar.fillAmount += 1f / delay * Time.deltaTime;
            if (progressBar.fillAmount == 1)
            {
                mainScript.AddGold(CalculateEarnAmount());
                progressBar.fillAmount = 0;
                clicked = false;
            }
        }
        
    }   

    public void Click()
    {
        if(progressBar.fillAmount == 0)
            clicked = true;
    }

    public void Buy()
    {
        if (mainScript.gold >= price)
        {
            amount++;

            if (amount == 5)
            {
                bonuses.Add(2);
            }
            if (amount == 10)
            {
                bonuses.Add(3);
            }

            mainScript.AddGold(-price);
            amountText.text = $"x{amount}";            
            price = price * 3;
            priceText.text = $"{price}$";
            earnAmountText.text = $"{CalculateEarnAmount()}$";
            
        }
    }

    public void BuyManager()
    {
        hasManager = true;
    }

    public int CalculateEarnAmount()
    {
        var totalEarnAmount = earnAmount * amount;
        foreach(var bonus in bonuses)
        {
            totalEarnAmount *= bonus;
        }        
        return totalEarnAmount;
    }
    
    public void SetData()
    {
        nameText.text = data.Name;
        var btn = this.GetComponent<Button>();
        btn.onClick.AddListener(Click);
    }
}

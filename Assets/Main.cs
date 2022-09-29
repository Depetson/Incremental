using Assets;
using TMPro;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update

    public int gold = 0;

    public TMP_Text goldText;
    public GameObject hajsorobPrefab;
    public GameObject Container;
    public int hajsorobCount = 0;
    void Start()
    {
        goldText.text = $"Hajsiwo: {gold}$";
        CreateHajsorob(0);
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
            //hajsorob.BuyManager();
            gold -= 100;
        }
    }

    public void CreateHajsorob(int id)
    {
        var go = GameObject.Instantiate(hajsorobPrefab);
        go.transform.SetParent(Container.transform, false);

        var hr = go.transform.GetChild(0).GetComponent<Hajsorob>();
        hr.data = DataSeed.Data[id];
        hr.SetData();
        hajsorobCount++;
    }

    public void Dodaj()
    {
        if (hajsorobCount < DataSeed.Data.Count)
        {
            CreateHajsorob(hajsorobCount);
        }
    }
}

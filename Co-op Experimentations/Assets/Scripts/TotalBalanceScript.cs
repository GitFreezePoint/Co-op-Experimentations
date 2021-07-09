using UnityEngine;
using UnityEngine.UI;

public class TotalBalanceScript : MonoBehaviour
{
    public Text TotalBalance;
    string lemonadeMoney;
    
    // Update is called once per frame
    void Update()
    {
        lemonadeMoney = GameObject.Find("LemonadeCollector").GetComponent<CollectorScript>().totalBalance.ToString();
        TotalBalance.text = lemonadeMoney;
    }
}

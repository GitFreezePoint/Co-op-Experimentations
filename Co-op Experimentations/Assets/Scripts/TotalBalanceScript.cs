using UnityEngine;
using UnityEngine.UI;

public class TotalBalanceScript : MonoBehaviour
{
    public Text TotalBalance;
    
    // Update is called once per frame
    void Update()
    {
        TotalBalance.text = GameObject.Find("LemonadeCollector").GetComponent<CollectorScript>().totalBalance.ToString();
    }
}

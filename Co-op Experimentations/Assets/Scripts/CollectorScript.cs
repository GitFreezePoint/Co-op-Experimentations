using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour
{
    public float totalBalance = 0f;
    bool CanPress = true;
    public float cooldownTime = 1f;
    float nextClickTime = 0f;
    public Slider ProgressSlider;
    public bool givenMoney = false;
    private float timerSpeed = 1f;
    private float elapsed;
    public class CountingTimer : MonoBehaviour { }


    public void Update()
    {

        if (Time.time > nextClickTime && !givenMoney)
        {
            totalBalance++;
            givenMoney = true;
        }

        //write code here corbiee worbieeee
        if (givenMoney==false)
            elapsed += Time.deltaTime;


        if (elapsed >= timerSpeed)
        {
            elapsed = 0f;
        }

        ProgressSlider.value = elapsed;
        ProgressSlider.maxValue = timerSpeed;

    }

    public void OnClick()
    {
        if (Time.time > nextClickTime)
        {
            ExecuteClick();
        }
    }

    void ExecuteClick()
    {
        //totalBalance++;
        nextClickTime = Time.time + cooldownTime;
        givenMoney = false;

    }  

    public void Upgrade() 
    {
        if(timerSpeed > .05f) {
            timerSpeed -= .05f;
            cooldownTime -= .05f;
        }
    }
}

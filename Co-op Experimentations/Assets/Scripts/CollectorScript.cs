using System.Collections;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    public float totalBalance = 0f;
    bool CanPress = true;
    public float cooldownTime = 1f;
    float nextClickTime = 0f;
    
    public void OnClick()
    {
        if(Time.time > nextClickTime) {
            ExecuteClick();
        }
    }
    void ExecuteClick()
    {
        totalBalance++;
        nextClickTime = Time.time + cooldownTime;
    }
}

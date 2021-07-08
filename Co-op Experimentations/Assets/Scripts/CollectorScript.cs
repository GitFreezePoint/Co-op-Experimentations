using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    public float totalBalance = 0f;
    float additiveValue = 1f;
    public float lemonBonus = 1f;
    
    public void OnClick() 
    {
        totalBalance += additiveValue *= lemonBonus;
    }
}

using UnityEngine;

public class Practice_4_Function : MonoBehaviour
{
    public void Awake()
    {
        Debug.Log($"<color=#f33>值:{boolitem()}</color>");
        Debug.Log($"<color=#f63>值:{boolitem1()}</color>");
    }
    public bool boolitem()
    {
        
        return true;
    }
    public bool boolitem1()
    {

        return false;
    }


}

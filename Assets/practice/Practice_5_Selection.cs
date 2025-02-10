using UnityEngine;
using static UnityEditor.Progress;

public class Practice_5_Selection:MonoBehaviour
{
    [SerializeField, Header("血量"), Range(0, 100)]
    private float hp = 100;

    private void Update()
    {
        switch (hp)
        {
            case>=80:
                Debug.Log("<color=#33f>血量安全</color>");
                break;
            case >= 60:
                Debug.Log("<color=#55f>健康狀態有狀況</color>");
                break;
            case >= 40:
                Debug.Log("<color=#3f3>警告，快喝水</color>");
                break;
            case >= 10:
                Debug.Log("<color=#33f>快死掉了</color>");
                break;
            case <= 0:
                Debug.Log("<color=#f11>已經死了</color>");
                break;
            default:
                break;

        }
    }

}

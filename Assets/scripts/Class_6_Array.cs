using UnityEngine;

public class Class_6_Array: MonoBehaviour
{
    private string[,,] characterNames =
    {
        {{"皮卡丘","雷丘","小火龍"} ,{ "妙蛙種子","烈空座","皮皮"} },
        { { "木妖","藍菇菇","菇菇寶貝"},{"嫩寶","藍水靈","綠菇菇" } },
        { { "狗頭人","提摩","艾希"},{ "希格斯","蓋倫","小法師"} }
    };

    private void Awake()
    {
        Debug.Log($"<color=#f6a>皮卡丘:{characterNames[0, 0, 0]}</color>");
        Debug.Log($"<color=#f6a>菇菇寶貝:{characterNames[1, 0, 2]}</color>");
        Debug.Log($"<color=#f6a>蓋倫:{characterNames[2, 1, 1]}</color>");
        Debug.Log($"<color=#f6a>第二頁第一排第三個:{characterNames[1, 1, 2]}</color>");
    }
}

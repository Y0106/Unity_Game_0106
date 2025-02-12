using UnityEngine;

namespace Yao
{
    #region <summary>類別 Class
    /// <summary>
    /// 類別 Class
    /// 類別:用來定義一個物件及他所擁有的資料與功能(成員)
    /// </summary> 
    #endregion
    public class Class_8_1_Class:MonoBehaviour
    {
        private void Awake()
        {
            //實例化 NPC 並儲存在 npcJack 變數內
            Class_8_1_NPC npcJack = new Class_8_1_NPC("傑克");
            Class_8_1_NPC npcYao = new Class_8_1_NPC("Yao","你好啊");

            npcJack.LogName();
            npcYao.LogName();
            npcJack.Talk();
            npcYao.Talk();
        }


    }
}

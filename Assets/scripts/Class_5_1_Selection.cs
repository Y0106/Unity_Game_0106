using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
// 命名空間:
//將類別分類，類似倉庫的概念，不同倉庫可以有相同名稱類別。
//語法:namespace 命名空間名稱{內容}
namespace Yao
{
    ///<summary>
    ///選取陳述式 Selection Statement
    ///1. if 判斷式
    ///2. Switch 判斷式
    ///</summary>
    public class Class_5_1_Selection : MonoBehaviour
    {
        [SerializeField, Header("血量"), Range(0, 100)]
        private int hP=100;
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        [SerializeField, Header("武器")]
        private string weapon;
        private void Awake()
        #region ...
        {
            //if判斷式
            //if (布林值) {陳述式}
            if (true)
            {
                Debug.Log("當bool為true則執行這行");
            }
            //快速完成:輸入if選取if陳述式案TAB或Enter
            if (false)
            {
                Debug.Log("當bool為false則此行不執行並且有綠蚯蚓");
            }

        }
        #endregion
        //更新事件:一秒鐘執行約60次(6fps) Frame Per Second
        private void Update()
        {
            //常用快捷鍵
            //1.格式化(自動排版) ctal+KD 
            //2.程式碼片段 ctal+KS 選region
            #region 判斷式if
            Debug.Log("<color=#f93>更新事件</color>");
            // 如果 isOpen 布林值等於 True，就顯示已經開門
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");
            }
            // 否則 isOpen 布林值等於 False，就顯示門關了
            else
            {
                Debug.Log("<color=#f93>門關了</color>");
            }
            //比較運算子、邏輯運算子結果為布林值
            //if 會在最上方、else在最下方，中間可用個else if
            //分數>60通過
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜C#課程過了</color>");
            }
            //40分補考
            else if (score >= 40)
            {
                Debug.Log("<color=#f96>補考</color>");
            }
            //20分可補考但要做專題繳交
            else if (score >= 20)
            {
                Debug.Log("<color=#f96>可補考但要做C#專題繳交</color>");
            }
            //<20當掉
            else
            {
                Debug.Log("<color=#3f3>你被當了</color>");
            }
            #endregion

            #region 判斷式 switch
            switch (weapon)
            {
                //case 值:
                //當判斷的值等於值時會執行這裡
                //break; 跳出判斷式
                //如果武器等於小刀等於攻擊=20
                //蝴蝶刀與小刀一樣
                case "蝴蝶刀":
                case "小刀":
                    Debug.Log("<color=#ff3>攻擊力:20</color>");
                    break;
                case "美工刀":
                    Debug.Log("<color=#ff3>攻擊力:10</color>");
                    break;
                case "屠刀":
                    Debug.Log("<color=#ff3>攻擊力:999</color>");
                    break;
                //當weapon 的值!=上面的所有值則執行此行
                default:
                    Debug.Log("<color=#ff3>無法使用此武器</color>");
                    break;

            }
            #endregion
            #region 練習
            //正確寫法
            if (hP >= 80)
            {
                Debug.Log("<color=#f93>血量安全</color>");
            }
            else if(hP>=60&& hP <80)
            {
                Debug.Log("<color=#f93>健康狀態有狀況</color>");
            }
            else if (hP >= 40&& hP < 60)
            {
                Debug.Log("<color=#f93>警告，快喝水</color>");
            }
            else if (hP >= 10 && hP < 40)
            {
                Debug.Log("<color=#f93>快死掉了</color>");
            }
            else if  (hP == 0)
            {
                Debug.Log("<color=#f93>快死掉了</color>");
            }
            
            #endregion
        }
        
    }
}

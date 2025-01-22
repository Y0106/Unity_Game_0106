using Unity.VisualScripting;
using UnityEngine;
namespace Yao
{
    /// <summary>
    /// 列舉：enumeration，C# 內關鍵字為簡寫 enum
    /// </summary>
    public class Class_5_2_Enumeration : MonoBehaviour
    {
        #region 認識列舉基本用法
        // 列舉：定義下拉選單的選項 (通常都是單選)
        // 語法：
        // 修飾詞 關鍵字 enum 列舉名稱 { 列舉選項 }
        // 定義一個列舉，名稱叫做季節
        // 列舉都是數值，預設從 0 開始
        private enum Season
        {
            // 定義列舉的選項
            Spring, Summer, Autumn, Winter
        }

        // 宣告變數，類行為季節的列舉，預設值為夏天
        [SerializeField, Header("季節")]
        private Season season = Season.Summer;

        private void Awake()
        //Awake第一個執行的程式
        {
            // 取得列舉的值 (Get) 抓出值
            Debug.Log(season);
            //取得舉列的整數值
            Debug.Log((int)season);

            // 設定列舉的值 (Set) 修改值
            season = Season.Winter;
            Debug.Log(season);
            //透過數值設定列舉
            season = (Season)2;
            Debug.Log(season);
        }
        #endregion
        //定義列舉的數值
        /// <summary>
        /// 道具
        ///</summary>
        private enum Item
        { 
            None = 0,Coin=1,RedWater=10,BlueWater=15,Chicken=20      
        }
        [SerializeField, Header("道具")]
        private Item item = Item.Chicken;
        //執行順序:Awake>Start>Update
        //開始事件:在喚醒事件後執行一次(初始化)
        private void Start()
        {
            Debug.Log((int)item);

            //列舉與判斷式 Switch
            //Switch+Tab*2>修改Switch_on 為列舉>Enter=快速完成
            switch (item)
            {
                case Item.None:
                    Debug.Log("沒有道具");
                    break;
                case Item.Coin:
                    Debug.Log("金幣");
                    break;
                case Item.RedWater:
                case Item.BlueWater:
                    Debug.Log("藥水道具");
                    break;
                case Item.Chicken:
                    Debug.Log("炸機");
                    break;
                default:
                    Debug.Log("這不是道具");
                    break;
            }
        }
    }
}
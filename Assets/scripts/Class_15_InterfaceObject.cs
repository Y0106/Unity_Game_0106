using UnityEngine;
using Yao.Tools;

namespace Yao.Class_15
{
    public class Class_15_InterfaceObject : MonoBehaviour
    {
        // 介面的使用步驟
        // 1.定義介面與介面成員
        // 2.類別資作介面
        // 3.實作介面的成員

        // 步骤 1.
        // 帶有「使用」功能的介面，遊戲內可被使用的物品
        public interface IUse
        {
            //不用宣告方法主體,不用寫大括號
            public void Use();
        }
        public interface IDestory
        {
            //不用宣告方法主體,不用寫大括號
            public void Destory();
        }
        //步驟2.
        // C# 單一繼承，多重實作介面
        public class Weapon : IUse
        {
            //步驟3.
            public void Use()
            { 
                LogSystem.LogWithColor("使用道武器，釋放武器技能", "#fa3");
            }
        }
        public class Potion : IUse, IDestory
        {
            public void Destory()
            {
                LogSystem.LogWithColor("藥水使用完畢，刪除", "#f11");

            }
            public void Use()
            {
                LogSystem.LogWithColor("使用藥水，恢復魔力", "#a3f");

            }
        }
        public class Chest : IUse, IDestory
        {
            public void Destory()
            {
                LogSystem.LogWithColor("寶相使用完畢，刪除", "#f11");

            }

            public void Use()
            {
                LogSystem.LogWithColor("使用寶相，隨機獲得道具", "#af3");

            }
        }


    }
}


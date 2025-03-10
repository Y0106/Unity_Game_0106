using UnityEngine;
using Yao.Tools;
using static Yao.Class_15.Class_15_InterfaceObject;

namespace Yao.Class_15
{
    /// <summary>
    /// 介面 interface
    /// </summary>
    public class Class_15_Interface : MonoBehaviour
    {
        public object inventoryFirst;
        public object inventorySecond;

        private void Awake()
        {
            int random = Random.Range(0, 3);  // 隨機 0 ~ 3（不會出現 3）
            LogSystem.LogWithColor($"隨機：{random}", "#F33");

            if (random == 0) inventoryFirst = new Prop();
            else if (random == 1) inventoryFirst = new Equipment();
            else if (random == 2) inventoryFirst = new Map();

            int randomSecond=Random.Range(0, 3); // 隨機 0 ~ 3（不會出現 3）

            if (randomSecond == 0) inventoryFirst = new Prop();
            else if (randomSecond == 1) inventoryFirst = new Equipment();
            else if (randomSecond == 2) inventoryFirst = new Map();
        }
        private void Update()
        {
            //按下數字1 可使用第一個物品
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                //如果第一格是道具就使用道具
                if (inventoryFirst is Prop) ((Prop)inventoryFirst).Use();
                //如果第一格是裝備就使用裝備
                else if (inventoryFirst is Equipment) ((Equipment)inventoryFirst).Use();
                //如果第一格是地圖就使用裝地圖
                else if (inventoryFirst is Map) ((Map)inventoryFirst).Use();
                //遊戲物品變多會很恐怖....
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                //如果第二格是道具的物品有實作介面就使用道具
                if (inventorySecond is IUse) ((IUse)inventorySecond).Use();
                if (inventorySecond is IDestory) ((IDestory)inventorySecond).Destory();
                //如果擴充物品判斷是不需要添加只需要讓物品都實作介面即可


            }
        }
    }
    public class Prop
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用道具，恢復體力", "#F96");
        }
    }

    public class Equipment
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用裝備，裝到對應位置", "#9F6");
        }
    }

    public class Map
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用地圖，開啟地圖功能", "#9F6");
        }
    }


}



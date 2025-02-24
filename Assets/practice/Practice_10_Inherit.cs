using UnityEngine;
using Yao.Tools;

namespace Yao
{
    public class Practice_10_Inherit : MonoBehaviour
    {
        private void Awake()
        {
            var redPotion = new Potion("紅色藥水");
            var bluePotion = new Potion("藍色藥水");
            Equipage helmet = new Equipage("頭盔");

            redPotion.Use();
            bluePotion.Use(100);
            helmet.Use();
        }

        public class Item
        {
            public string name;
            public Item(string _name)=>name = _name;

            public virtual void Use()
            {
                LogSystem.LogWithColor($"道具名稱：{name}", "#33f");
            }
        }

        public class Potion : Item
        {
            public Potion(string _name) : base(_name)
            {
            }
            public void Use(int increase)
            {
                LogSystem.LogWithColor($"{name}藥水，恢復量:{increase} MP", "#ff0");
            }
        }

        public class Equipage : Item
        {
            public Equipage(string _name) : base(_name)
            {
            }
            public override void Use()
            {
                LogSystem.LogWithColor($"裝備：{name}", "#77f");
            }
        }
    }
}
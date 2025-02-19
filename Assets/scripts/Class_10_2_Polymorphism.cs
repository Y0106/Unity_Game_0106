using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Yao.Tools;

namespace Yao
{
    /// <summary>
    /// 多形
    /// </summary>
    public class Class_10_2_Polymorphism:MonoBehaviour
    {
        private void Awake()
        {
            Trap trap1 = new Trap("落穴", 3);
            Magic magic1 = new Magic("死者復甦", 5);

            //多形:多種形式，可以使用父類別或者自己的成員
            trap1.Information();   //型式1:呼叫父類別的無參數方法
            trap1.Information(37); //型式2:呼叫自己有一個參數方法

            //多形:宣告時使用父類別，實列化的類別會決定型式
            Card card1 = new Card("一般卡片", 0);
            Card magic2 = new Magic("羽毛掃", 7);
            card1.Information();   //型式1:呼叫 Card 的方法
            magic2.Information(); //型式2:呼叫 Magic 的方法
        }
    }
    public class Card
    {
        public string name;
        public int cost;

        public Card(string _name, int _cost)
        {
            name = _name;
            cost = _cost;
        }
        public virtual void Information()
        {
            LogSystem.LogWithColor($"{name}這是一張卡", "#f3d");
        }
    }

    public class Trap : Card
    {
        public Trap(string _name, int _cost) : base(_name, _cost)
        {
        }
        public void Information(int index)
        {
            LogSystem.LogWithColor($"這是一張陷阱卡 編號:{index}", "#f77");
        }
    }

    public class Magic : Card
    {
        public Magic(string _name, int _cost) : base(_name, _cost)
        {
        }

        public override void Information()
        {
            LogSystem.LogWithColor($"{name}這是一張魔法卡", "#77f");
        }
    }
}


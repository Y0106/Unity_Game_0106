using System;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Yao.Tools;

namespace Yao
{
    /// <summary>
    /// 泛型 Generics
    /// </summary>
    public class Class_15_Generics:MonoBehaviour
    {
        private void Awake()
        {
            #region 不使用泛型
            int numberA = 7, numberB = 9;
            LogSystem.LogWithColor($"數字A與B:{numberA}|{numberB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogWithColor($"數字A與B:{numberA}|{numberB}", "#f93");

            char charA = '嗨', charB = '嘿';
            LogSystem.LogWithColor($"字元A與B:{charA}|{charB}", "#f93");
            SwpChar(ref charA, ref charB);
            LogSystem.LogWithColor($"字元A與B:{charA}|{charB}", "#f93");

            object objA = 3.5f, objB = 7.7f;
            LogSystem.LogWithColor($"字元A與B:{objA}|{objB}", "#f93");
            SwpObject(ref objA, ref objB);
            LogSystem.LogWithColor($"字元A與B:{objA}|{objB}", "#f93");
            #endregion

            bool boolA = true, boolB = false;
            LogSystem.LogWithColor($"A與B:{boolA}|{boolB}", "#f93");
            Swap(ref boolA, ref boolB);
            LogSystem.LogWithColor($"A與B:{boolA}|{boolB}", "#f93");

            byte byteA = 1, byteB = 9;
            LogSystem.LogWithColor($"A與B:{byteA}|{byteB}", "#9f9");
            Swap<byte>(ref byteA ,ref byteB);
            LogSystem.LogWithColor($"A與B:{byteA}|{byteB}", "#9f9");

            var player1 = new DataPlayer<int>();
            player1.data = 99;
            player1.LogData(123);

            var player2 = new DataPlayer<string>();
            player2.data = "玩家二號";
            player2.LogData("哈囉");
        }
        #region 方法區域

        /// <summary>
        /// 數字對調
        /// </summary>
        /// <<paral name="a">第一個數字く/param＞
        /// <<paral name="b">第二個數字く/param＞
        public void SwapNumber(ref int a, ref int b)
        {
            int temp = a;//將第一個數字放去旁邊(暫存)
            a = b;         //將第二個數字放到第一個數字內
            b = temp;      //將旁邊的數字放到第二個數字

        }
        /// <summary>
        /// 字元對調
        /// </summary>
        public void SwpChar(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
        /// <summary>
        /// 物件對調
        /// </summary>
        public void SwpObject(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }
        ///<summary〉
        ///使用泛型進行對調
        ///</summary>
        //<typeparam name="T">要對調的資料類型</typeparam>
        //<param name="a">第一個資料</param>
        //<param name="b">第二個窅料</param>
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        #endregion

        private void Start()
        {
            var player = new Player();
            var enemy=new Enemy();
            var attackEvent = new AttackEvent<Player, Enemy>();
            attackEvent.Attack(player, enemy);

            var hp = new Hp();
            var attack = new Attack();
            hp.Increase(10.5f);
            attack.Increase(50);
            hp.Increase(3.75f);

            var checker = new CheckValue<Hp, float>();
            checker.Chack(hp);
        }
    }
    #region 泛型類別
    public class DataPlayer<T>
    {
        public T data;
        public void LogData(T data)
        {
            LogSystem.LogWithColor(data, "#9f9");
        }

    }
    public class Player { }
    public class Enemy { }

    public class AttackEvent<T, U>
    {
        public void Attack(T attacker, U defender)
        {
            LogSystem.LogWithColor($"{attacker} 攻擊{defender}", "#9f9");
        }

    }
    #endregion

    #region 泛型介面
    //泛型介面 
    public interface IStat<T>
    {
        public T value { get; set; }  //該狀態的值
        public void Increase(T amount);   //增加該狀態

    }

    public class Hp : IStat<float>
    {
        public float value { get; set; }

        public void Increase(float amount)
        {
            value += amount;
            LogSystem.LogWithColor($"血量{value}", "#f3f");
        }
    }
   
    public class Attack : IStat<int>
    {
        public int value { get; set; }
        public void Increase(int amount)
        {
            value += amount;
            LogSystem.LogWithColor($"攻擊力{value}", "#f3f");

        }

    }
    #endregion

    //泛型約束:泛型T必須實作IStat<T>介面
    public class CheckValue<T, U> where T : IStat<U>
    {
        public void Chack(T stat)
        {
            //添加約束後可以使用
            LogSystem.LogWithColor($"狀態的值:{stat.value}", "#3d3");


        }
    }
}


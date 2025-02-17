using UnityEngine;
using static Yao.Practice_8_Boss;

namespace Yao
{
    public class Practice_8_Class:MonoBehaviour
    {
        private void Awake()
        {
            Practice_8_Boss bossDeagon = new Practice_8_Boss("火龍","龍之吐息",2999);
            Practice_8_Boss bossBird = new Practice_8_Boss("裂空座","光束砲",3999);
            Debug.Log($"<color=#3f3>{bossDeagon.name},招式:{bossDeagon.skill}</color>");
            Debug.Log($"<color=#3f3>{bossBird.name},招式:{bossBird.skill}</color>");
        }
    }

    public class Practice_8_Boss
    {
        public string name;
        public string skill;
        public float hp;

        public Practice_8_Boss(string _name,string _skill,float _hp)
        { 
            name=_name;
            skill=_skill;
            hp=_hp;


        
        }
    }
}

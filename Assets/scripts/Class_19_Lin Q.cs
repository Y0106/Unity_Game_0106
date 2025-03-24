using UnityEngine;
using System.Linq;//引用LinQ命名空間
using Yao.Tools;

namespace Yao.Class_19.LinQ
{
    /// <summary>
    /// LinQ 整合查詢語言 Language Intrgrated Query
    /// 查詢資料庫，所有程式語言共用技術
    /// </summary>
    public class Class_19_LinQ : MonoBehaviour
    {
        public int[] scores = { 90,80,77,88,93,1,5,10,35 };

        private void Awake()
        {
            //使用 LinQ的關鍵字查詢資料
            //起手式:
            //fromy 資料來源
            //select選取結果
            //說明:選取scores內的每一筆分數
            var queryAllData=from score in scores
                             select score;
            foreach (var item in queryAllData)
            { 
                LogSystem.LogWithColor(item,"#3f3");
            }
            //情境:希望找到大於60分的玩家分數並且排序
            //where 篩選的條件
            //orderby 排序(預設從小到大)descending由大到小
            var querySisty=from score in scores
                           where score >=60
                           orderby score descending
                           select score;
            foreach (var item in querySisty)
            {
                LogSystem.LogWithColor(item, "#ff3");
            
            }

            //情境:篩選出分數為偶數的資料與奇數
            //grouop by
            var queryGrouop = from score in scores
                              group score by score % 2;

            foreach (var group in queryGrouop)
            {
                LogSystem.LogWithColor(group, "#f11");
                foreach (var item in group)
                {
                    LogSystem.LogWithColor(item, "#79f");
                }
                LogSystem.LogWithColor("------群組分隔線-------","#79f");

            }


        }

    }
}

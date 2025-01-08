//單行註解
/*多行註解*/
//引用Unity遊戲引擎的韓式庫(開發遊戲的程式集合，命名空間)
using UnityEngine;
//修飾詞類別關鍵字(腳本)類別名稱腳本名稱//MonoBehaviour控制遊戲物件並可與之互動
public class Class_1_Variable:MonoBehaviour 

{
    //程式內的括號都是成對出現{} () "" <> [] ''
    //class{}此類別的程式內容
    //變數:會改變的值，用來從放遊戲或系統內的資訊
    //變數語法:變數資料類型 變數名稱;
    //資料類型告訴記憶體可放入那些資料
    //變數名稱:習慣用小寫開頭命名，駝峰式命名，規則與腳本名稱相同
    //公開:充許其他類別存取public
    //私人:禁止其他類別存取private(預設)
    public int coin=500;
    private int value=3;
}
//類別外，不要將程式寫在這
using UnityEngine;
//三條斜線是摘要(XML 語言)用來做簡短說明，可加在類別與變數上方
/// <summary>
/// 認識資料類型
/// </summary>

public class Class_2_DataType:MonoBehaviour
{
    //變數語法 :修飾詞 資料類型 便是名稱 只並 預設值;
    //四大常用資料類型
    //整數int 浮點數float 字串string 布林值 bool->true||false兩值
    public int count = 7;
    public float moveSpeed = 3.5f;   //+f大小寫皆可
    public float trunSpeed = 30.5F;
    
    public bool isDead=false;  //結果:否
    public bool gameOver=true; //解果:是

    public long item = 99999;//64位元
    public ushort item1 = 10000;//16位元
    public byte item2 = 100;//8位元

    public char item3 = 'h';//單一字元''
    public string character = "蓋倫";//字串""

    //public byte item4 = 256;//溢位導致錯誤


}

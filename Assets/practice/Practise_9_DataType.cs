using Yao.Tools;
using UnityEngine;


namespace Yao
{

    public class Practise_9_DataType : MonoBehaviour
    {

        private void Awake()
        {
            float number = -999.321f;
            sbyte  byteNumber = (sbyte)number;
            LogSystem.LogWithColor(byteNumber, "#f33");

            
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreControl : MonoBehaviour
{
    public Text ScriptTxt; //text 입력하기 위한 창
    public static int score = 0; //점수 입력하기 위한 장소

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hpControl.hp > 0)
        {
            if (playerCollider.finish)
            {
                ScriptTxt.text = "";
            }
            else { ScriptTxt.text = score.ToString(); }
        }
        else
        {
            ScriptTxt.text = "";
        }
    }
}

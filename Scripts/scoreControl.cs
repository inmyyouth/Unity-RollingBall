using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreControl : MonoBehaviour
{
    public Text ScriptTxt; //text �Է��ϱ� ���� â
    public static int score = 0; //���� �Է��ϱ� ���� ���

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpControl : MonoBehaviour
{
    public Text ScriptTxt; //text �Է��ϱ� ���� â
    public static int hp = 10; //���� �Է��ϱ� ���� ���

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            ScriptTxt.text = "";
        }
        else
        {
            if (playerCollider.finish)
            {
                ScriptTxt.text = "";
            }
            else
            {
                ScriptTxt.text = hp.ToString();
            }
        }
    }
}

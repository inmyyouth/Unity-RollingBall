using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class viewScore : MonoBehaviour
{
    public Text viewScoreTxt; //text �Է��ϱ� ���� â

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerCollider.finish)
        {
            viewScoreTxt.text = scoreControl.score.ToString();
        }
        else
        {
            viewScoreTxt.text = "0";
        }
    }
}

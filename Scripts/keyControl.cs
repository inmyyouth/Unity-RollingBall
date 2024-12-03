using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyControl : MonoBehaviour
{
    public static int key = 0;

    public Image lemon;

    // Start is called before the first frame update
    void Start()
    {
        lemon.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (key > 0)
        {
            lemon.enabled = true;
        }
        else
        {
            lemon.enabled = false;
        }
        
    }
}

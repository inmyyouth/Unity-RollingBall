using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howToScript : MonoBehaviour
{
    public GameObject howToPanel;

    // Start is called before the first frame update
    void Start()
    {
        howToPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MainMenu.howto)
        {
            howToPanel.SetActive(true);
        }   
    }
}

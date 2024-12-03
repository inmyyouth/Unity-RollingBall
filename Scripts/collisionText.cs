using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionText : MonoBehaviour
{
    int hp = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            hp -= 1;
            Debug.Log("hp = " + hp);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

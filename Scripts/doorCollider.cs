using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCollider : MonoBehaviour
{
    public static GameObject door;
    public ParticleSystem explosion;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Collider col = gameObject.GetComponent<Collider>();
            if (keyControl.key == 1)
            {   
                Destroy(gameObject);
                keyControl.key = 0;
                explosion.Play();
            }
            else
            {
                col.isTrigger = false;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(keyControl.key == 1)
        {
            Collider col = gameObject.GetComponent<Collider>();
            col.isTrigger = true;
        }
    }
}

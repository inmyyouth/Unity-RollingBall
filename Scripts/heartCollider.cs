using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartCollider : MonoBehaviour
{
    public AudioClip cherry;
    public ParticleSystem particles;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            hpControl.hp += 1;
            Destroy(gameObject);
            particles.Play();

            AudioSource.PlayClipAtPoint(cherry, transform.position);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCollider : MonoBehaviour
{
    public AudioClip key;
    public ParticleSystem particles;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            keyControl.key = 1;
            Destroy(gameObject);
            particles.Play();

            AudioSource.PlayClipAtPoint(key, transform.position);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCollider : MonoBehaviour
{
    public AudioClip peach;
    public ParticleSystem particles;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            scoreControl.score += 100;
            Destroy(gameObject);
            particles.Play();

            AudioSource.PlayClipAtPoint(peach, transform.position); 
        }
    }
}

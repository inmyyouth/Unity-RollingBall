using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollider : MonoBehaviour
{
    public ParticleSystem particles;
    public ParticleSystem firework;
    public static bool finish = false;
    public static bool count;
    public static bool finishJump;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            hpControl.hp -= 1;
            particles.Play();
        }
        if (collision.gameObject.tag.Equals("Boss")) 
        {
            hpControl.hp -= 3;
            particles.Play();
        }
        if (count)
        {
            if (!playerManager.gameOver & finishJump)
            {
                if (collision.gameObject.tag.Equals("mul2"))
                {
                    scoreControl.score *= 2;
                    finish = true;
                    count = false;
                    firework.Play();
                }
                if (collision.gameObject.tag.Equals("mul3"))
                {
                    scoreControl.score *= 3;
                    finish = true;
                    count = false;
                    firework.Play();
                }
                if (collision.gameObject.tag.Equals("mul5"))
                {
                    scoreControl.score *= 5;
                    finish = true;
                    count = false;
                    firework.Play();
                }
            }
        }
    }   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            hpControl.hp -= 1;
            particles.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        count = true;
        finishJump = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

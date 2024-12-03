using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private bool IsJumping;
    private bool SuperJumping;
    public AudioClip jump;

    // Start is called before the first frame update
    void Start()
    {
        IsJumping = false;
        SuperJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!IsJumping)
            {
                IsJumping = true;
                GetComponent<Rigidbody>().AddForce(Vector3.up * 5.0f, ForceMode.Impulse);
            }
        }

        //direction
        if (Input.GetKeyDown(KeyCode.W)) //W, D를 빼거나 rigid body에서 Z 고정
        {
            if (!SuperJumping)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.forward * 5.0f, ForceMode.Impulse);
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 5.0f, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 5.0f, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 5.0f, ForceMode.Impulse);
        }

        if (playerManager.gameOver || playerCollider.finish)
        {
            gameObject.GetComponent<playerMove>().enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsJumping = false;
            SuperJumping = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SuperJump"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 13.0f, ForceMode.Impulse);
            playerCollider.finishJump = true;
            SuperJumping = true;

            AudioSource.PlayClipAtPoint(jump, transform.position);
        }
    }
}

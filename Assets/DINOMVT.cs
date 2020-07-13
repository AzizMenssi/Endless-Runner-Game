using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DINOMVT : MonoBehaviour
{
    Rigidbody2D rb;
    bool grounded;
    Animator anime;
    bool crouching;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")&& grounded)
        {
            rb.velocity += Vector2.up * 15;
            anime.speed = 0;
        }
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -4.2f, Mathf.Infinity);
        transform.position = pos;
        crouching = grounded && Input.GetAxisRaw("Vertical") < 0;
        anime.SetBool("crouching", crouching);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            grounded = true;
            anime.speed = 1;
        }
        if (collision.collider.CompareTag("Harm"))
        {
            Time.timeScale = 0;
            GameManager.gameOver = true;
        }
    }
    private void OnCollisionExit2D (Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            grounded = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpH;

    public Animator flapping;
    public Animator death;
    public bool GameOver;

    public GameObject GameOverScene;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && GameOver == false)
        {
            rb.AddForce(Vector2.up * jumpH, ForceMode2D.Impulse);
            flapping.Play("PlayerFlap");
        }

        if (GameOver == true)
        {
            GameOverScene.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    public void JumpingPlayer()
    {
        if (GameOver == false)
        {
            rb.AddForce(Vector2.up * jumpH, ForceMode2D.Impulse);
            flapping.Play("PlayerFlap");
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            death.Play("PlayerDeath");
            GameOver = true;
        }
    }
}

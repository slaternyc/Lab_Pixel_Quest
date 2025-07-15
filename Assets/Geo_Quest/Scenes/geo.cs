using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

// Variables
public class geo : MonoBehaviour
{
    private int varOne = 1;

    private string Shinken = "Wassup";

    private Rigidbody2D rb;
    private SpriteRenderer sb;
    public int speed = 3;

    public string nextLevel = "Level 2";

    // Start is called before the first frame update
    void Start()
    {
        int varTwo = 2;
        Debug.Log("Hello World!");
        string Kenshin = " dude";
        Debug.Log(Shinken + Kenshin);

        rb = GetComponent<Rigidbody2D>();
        sb = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        float xSpeed = Input.GetAxis("Horizontal");
        Debug.Log(xSpeed);

        rb.velocity = new Vector2(xSpeed * speed, rb.velocity.y);


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sb.color = Color.grey;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sb.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sb.color = Color.yellow;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            sb.color = Color.green;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       switch (collision.tag)
       {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
            
               {
                    SceneManager.LoadScene(nextLevel);
                    break;
        }      }
    
            
    }   
}
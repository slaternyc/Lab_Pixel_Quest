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
    public int speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        int varTwo = 2;
        Debug.Log("Hello World!");
        string Kenshin = " dude";
        Debug.Log(Shinken + Kenshin);

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float xSpeed = Input.GetAxis("Horizontal");
        Debug.Log(xSpeed);

        rb.velocity = new Vector2(xSpeed * speed, rb.velocity.y);
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

            } 
    
            
    }   
}
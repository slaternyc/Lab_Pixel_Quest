using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;               // Player Physics Controller
    private SpriteRenderer _spriteRenderer;         // Player Image Controller
    public int speed = 4;
        
    
    // Start is called before the first frame update

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(horizontal * speed, _rigidbody2D.velocity.y);

        if (horizontal > 0){ _spriteRenderer.flipX = true;}
        else if (horizontal < 0) { _spriteRenderer.flipX = false;}
    }
}

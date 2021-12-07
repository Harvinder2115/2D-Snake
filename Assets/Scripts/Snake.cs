using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour
{
    public float Speed;

    Vector2 dir = Vector2.up;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Move", 0.3f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            dir = Vector2.right;
            
        else if (Input.GetKey(KeyCode.LeftArrow))
            dir = -Vector2.right;
        else if (Input.GetKey(KeyCode.DownArrow))
            dir = -Vector2.up;
        else if (Input.GetKey(KeyCode.UpArrow))
            dir = Vector2.up;
        // float horizontal = Input.GetAxisRaw("Horizontal");
        // float vertical = Input.GetAxisRaw("Vertical");

        // Move(horizontal, vertical);
    }

    void Move()//(float horizontal, float vertical)
    {
        transform.Translate(dir);
        // Vector3 position = transform.position;
        // position.y += vertical * Speed * Time.deltaTime;
        // position.x += horizontal * Speed * Time.deltaTime;
        // transform.position = position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] float MoveSpeed;
    float vertical, horizontal;
    Rigidbody2D myRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }
    void MoveBall()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        myRigidbody2D.velocity = new Vector2(horizontal * MoveSpeed , vertical * MoveSpeed );
    }
    
}

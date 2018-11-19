using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    public int currentState;
    public Animator animator;
    public int newState;
    //animation states - the values in the animator conditions

    public Vector2 up = new Vector2(0, 1);
    public Vector2 down = new Vector2(0, -1);
    public Vector2 left = new Vector2(-1, 0);
    public Vector2 right = new Vector2(1, 0);
    public Vector2 idle = new Vector2(0, 0);

    // Use this for initialization
    void Start()
    {
        speed = 6;
        animator = this.GetComponent<Animator>();
        animator.SetBool("isMoving", false);
        animator.SetInteger("Direction", 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        Vector2 v3 = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(speed * v3.normalized * Time.deltaTime);

        

        if (Equals(v3.normalized, up))
        {
            changeState(1, true);

        }
        else if (Equals(v3.normalized, down))
        {
            changeState(0, true);
            //Debug.Log(animator.GetBool("isMoving"));


        }
        else if (Equals(v3.normalized, left))
        {
            changeState(2, true);

        }
        else if (Equals(v3.normalized, right))
        {
            changeState(3, true);

        }
        else if(Equals(v3.normalized, idle))
        {
            int prev = animator.GetInteger("Direction");
            changeState(prev, false);
        }

    }

    void changeState(int dir, bool isMoving)
    {
        
        animator.SetInteger("Direction", dir);
        animator.SetBool("isMoving", isMoving);
    }
}

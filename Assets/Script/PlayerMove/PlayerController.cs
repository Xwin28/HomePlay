using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private Vector3 moveDir;
    private Vector3 lastMoveDir; 
    [SerializeField] private Animator animator;
    [SerializeField] private int Speed = 10;
    private Vector2 Move;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        Move = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {

       Move = new Vector2(0,0);

        Move.x = Input.GetAxisRaw("Horizontal");
        Move.y = Input.GetAxisRaw("Vertical");
        moveDir = new Vector3(Move.x, Move.y).normalized;

        animator.SetFloat("Horizontal", moveDir.x);
        animator.SetFloat("Vertical", moveDir.y);
        animator.SetFloat("Speed", Move.sqrMagnitude);
        float Velocity = Move.sqrMagnitude;
        animator.SetFloat("Speed", Velocity);
        if (Velocity <= 0.01)
        {
            animator.SetFloat("FaceH", lastMoveDir.x);
            animator.SetFloat("FaceV", lastMoveDir.y);
            
        }
        else
        {
            moveDir = new Vector3(Move.x, Move.y).normalized;
            animator.SetFloat("Horizontal", Move.x);
            lastMoveDir = moveDir;
            animator.SetFloat("Vertical", Move.y);
        }



        Debug.Log("Move = "+ Move.sqrMagnitude);
        //moveDir = new Vector3(moveX, moveY).normalized;


    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = moveDir*Speed;
    }
}

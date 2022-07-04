using System.Collections;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 10f;
    public bool standing;
    public float speedslow = 0.3f;
    public Rigidbody2D rigidbody2d;
    public Vector2 maxvelocity = new Vector2(3, 5);
    public AudioClip audioClip;
    //public Vector2 MaxVelocity = new Vector2(2, 3);
    public Animator animvar;

    void Start()
    {
        animvar = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        float NewY = Mathf.Abs(rigidbody2d.velocity.y);
        float NewX = Mathf.Abs(rigidbody2d.velocity.x);
        if (NewY < 0.2f)
            standing = true;
        else
            standing = false;

        var forceX = 0f;
        var forceY = 0f;
        var absVelX = Mathf.Abs(rigidbody2d.velocity.x);
        if (Input.GetKey("right"))
        {
            if (NewX < maxvelocity.x)
            {
                forceX = standing ? speed : speed * speedslow;
                animvar.SetInteger("animtrans", 1);
                AudioSource.PlayClipAtPoint(audioClip, transform.position);
            }
            else
                animvar.SetInteger("animtrans", 0);
            transform.localScale = new Vector3(1, 1, 1);


        }

        else if (Input.GetKey("left"))
        {
            if (NewX < maxvelocity.x)
            {
                forceX = standing ? -speed : -speed * speedslow;
                animvar.SetInteger("animtrans", 1);
                AudioSource.PlayClipAtPoint(audioClip, transform.position);
            }
            else
                animvar.SetInteger("animtrans", 0);
            transform.localScale = new Vector3(-1, 1, 1);

        }
        else if (Input.GetKey("up"))
        {
            if (NewY < maxvelocity.y)
            {
                forceY = speed;
                animvar.SetInteger("animtrans", 2);
            }
            else
                animvar.SetInteger("animtrans", 0);
            transform.localScale = new Vector3(1, 1, 1);

        }
        rigidbody2d.AddForce(new Vector2(forceX, forceY));
    }
}

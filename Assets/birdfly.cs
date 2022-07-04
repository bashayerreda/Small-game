using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdfly : MonoBehaviour
{
    private Animator animator;
    public float DelayTime = 3.5f;
    public AppleHid appleHid;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (DelayTime > 0)
        {
            StartCoroutine(OnTimeEvent());
        }
        }

    // Update is called once per frame
    void Update()
    {
            animator.SetInteger("StatePar", 0);
        }
    IEnumerator OnTimeEvent()
    { //timer for display
        yield return new WaitForSeconds(DelayTime);
        Fire();
        StartCoroutine(OnTimeEvent());
    }

    void Fire()
    {
        animator.SetInteger("StatePar", 1);
    }
    void Shotting()
    {

        if (appleHid)
        {
            AppleHid clone = Instantiate(appleHid, transform.position, Quaternion.identity) as AppleHid;
        }
    }
}

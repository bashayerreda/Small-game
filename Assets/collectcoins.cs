using System.Collections;
using UnityEngine;

public class collectcoins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "player")
        {
            Destroy(gameObject);
            //sd.value = sd.value + 1;
        }
    }
}
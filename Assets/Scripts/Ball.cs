using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            GameManager.instance.GameOver();
        }
    }

    public void ToStartPosition()
    {
        transform.position = startPosition;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50.0f;

    private Quaternion startRotation;

    public Joystick joystick;

    void Start()
    {
        startRotation = new Quaternion(0, 0, 0, 0);
    }

    void Update()
    {
        float hInput = Mathf.Clamp(joystick.Horizontal * speed * Time.deltaTime, -30, 30);
        float vInput = Mathf.Clamp(joystick.Vertical * speed * Time.deltaTime, -30, 30);

        transform.Rotate(new Vector3(vInput, 0, -hInput));
    }

    public void ToStartRotation()
    {
        transform.rotation = startRotation;
    }
}

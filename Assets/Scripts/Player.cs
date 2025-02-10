using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick joystick;
    public float moveSpeed = 0;
    float hInput, vInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate(){
        hInput = joystick.Horizontal * moveSpeed;
        vInput = joystick.Vertical * moveSpeed;

        transform.Translate(hInput, vInput, 0);

    }
}

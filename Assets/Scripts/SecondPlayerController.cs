using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    public GameObject mainCamera;
    public GameObject camera;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal2");
        forwardInput = Input.GetAxis("Vertical2");
        //Двигаем автомобиль по вертикальной оси
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Двигаем автомобиль по горизонтальной оси
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            speed = 30.0f;
        }

        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            speed = 20.0f;
        }
    }
}

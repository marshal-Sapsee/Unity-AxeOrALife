using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Двигаем автомобиль по вертикальной оси
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Двигаем автомобиль по горизонтальной оси
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 30.0f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 20.0f;
        }
        
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (mainCamera.active == false) mainCamera.SetActive(true);
            else mainCamera.SetActive(false);
        }
    }
}

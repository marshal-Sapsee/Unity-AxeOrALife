using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SecondWheelRotating : MonoBehaviour
{
    private float verticalInput;
    

    private float speedRotate = 45.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("VerticalSecond");
        //Двигаем колеса по горизонтальной оси
        transform.Rotate(Vector3.left,speedRotate  * verticalInput * Time.deltaTime * 5);
    }
}

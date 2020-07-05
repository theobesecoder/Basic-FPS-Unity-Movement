using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeedX = 15.0f;
    private float rotationSpeedY = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //To rotate the camera first we need the access to both Mouse X and Mouse Y.
        float inputX = Input.GetAxis("Mouse X");
        float inputY = Input.GetAxis("Mouse Y");

        float resultX = transform.rotation.eulerAngles.x - (inputY * rotationSpeedY * Time.deltaTime);
        float resultY = transform.rotation.eulerAngles.y + (inputX * rotationSpeedX * Time.deltaTime);


        //Apply angles to the camera
        transform.rotation = Quaternion.Euler(resultX, resultY, 0f);
        
    }
}

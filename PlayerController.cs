using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float movementSpeed = 5f;
    [SerializeField]
    public Transform cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 cameraRotation = cameraPos.transform.rotation.eulerAngles;

        cameraRotation.x = cameraRotation.z = 0; //As we only need the mouse horizontal axis movement for movement.

        Vector3 offset = new Vector3(inputX, 0, inputZ) * Time.deltaTime * movementSpeed;

        offset = Quaternion.Euler(cameraRotation) * offset;

        transform.position += offset; 
    }
}

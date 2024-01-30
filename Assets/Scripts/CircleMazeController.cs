using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircleMazeController : MonoBehaviour
{
    float currentAngle = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.A))
        {
            currentAngle += 0.5f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            currentAngle -= 0.5f;
        }

        float number = currentAngle + zInput; 
        //transform.rotation = Quaternion.Euler(90, transform.rotation.y, transform.rotation.z + zInput);
        transform.localEulerAngles = new Vector3(0f, 0f, currentAngle);

    }
}

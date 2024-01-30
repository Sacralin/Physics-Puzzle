using UnityEngine;

public class MazeController : MonoBehaviour
{
    public float rotationSpeed = 15f;
    private float rotationLimit = 45f;
    private float currentXRotation = 0f;
    private float currentZRotation = 0f;


    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Vertical");        
        float zInput = Input.GetAxis("Horizontal");

        currentXRotation += -xInput * rotationSpeed * Time.deltaTime;
        currentZRotation += -zInput * rotationSpeed * Time.deltaTime;

        currentXRotation = Mathf.Clamp(currentXRotation, -rotationLimit, rotationLimit);
        currentZRotation = Mathf.Clamp(currentZRotation, -rotationLimit, rotationLimit);

        transform.rotation = Quaternion.Euler(currentXRotation, 0f, currentZRotation);
    }
}

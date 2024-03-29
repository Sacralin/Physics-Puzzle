using UnityEngine;

public class OpenMazeDoor : MonoBehaviour
{
    public Transform doorAnchorPoint;
    private float targetDoorPosition;
    private float currentDoorPosition;
    private float doorOpenSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        targetDoorPosition = 0f;
        currentDoorPosition = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentDoorPosition != targetDoorPosition)
        {
            SetDoorPosition();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            targetDoorPosition = -90f;
        }
        
    }

    private void SetDoorPosition()
    {
        float newDoorYPosition = currentDoorPosition -= doorOpenSpeed * Time.deltaTime;
        doorAnchorPoint.localEulerAngles = new Vector3(0f, newDoorYPosition, 0f);
        if(currentDoorPosition < targetDoorPosition)
        {
            currentDoorPosition = targetDoorPosition;
        }
    }

   
}

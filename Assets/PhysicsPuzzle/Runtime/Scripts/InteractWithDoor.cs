using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithDoor : MonoBehaviour
{
    public PuzzleInputs inputActions;
    public CinemachineVirtualCamera puzzleCamera;

    // Start is called before the first frame update
    void Start()
    {
        inputActions = new PuzzleInputs();
        inputActions.PuzzleControls.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (inputActions.PuzzleControls.Interact.triggered)
            {
                puzzleCamera.Priority = 100;
            }

            if (inputActions.PuzzleControls.Exit.triggered)
            {
                puzzleCamera.Priority = 0;
            }

        }
    }

    public void PuzzleComplete()
    {
        puzzleCamera.enabled = false;
    }
}

using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Camera mainCamera;
    private NavMeshAgent agent;
    private PlayerInput input;

    void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        input = GetComponent<PlayerInput>();
    }
    private void Update()
    {
        if (input.currentMouse.leftButton.isPressed)
        {
            MovePlayer();
        }
    }
    private void MovePlayer()
    {
        Ray ray = mainCamera.ScreenPointToRay(input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(hit.point);
            agent.SetDestination(hit.point);
        }
    }
}

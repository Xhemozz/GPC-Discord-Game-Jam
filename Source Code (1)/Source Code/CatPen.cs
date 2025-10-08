using UnityEngine;
using UnityEngine.AI;

public class CatPen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cat"))
        {
            NavMeshAgent agent = other.GetComponent<NavMeshAgent>();
            CatAI wander = other.GetComponent<CatAI>();
            agent.isStopped = true;
        }
    }
}

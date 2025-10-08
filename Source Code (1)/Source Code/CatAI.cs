using UnityEngine;
using UnityEngine.AI;

public class CatAI : MonoBehaviour
{
    private NavMeshAgent agent;
    private float distance;
    private float timer = 0f;
    private float waitTimer = 1f;

    public Transform followTarget;
    [SerializeField] private float walkRadius;
    [SerializeField] private float playerRange;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        distance = Vector3.Distance(transform.position, followTarget.position);

        if (distance < playerRange)
        {
            agent.speed = 5f;
            agent.SetDestination(followTarget.position);
        }
        else if (timer < waitTimer)
        {
            timer += Time.deltaTime;
            Wander();
        }
        else
            timer = 0f;

    }

    private void Wander()
    {
        Vector3 randomDir = Random.onUnitSphere * walkRadius;
        var randomPoint = randomDir + transform.position;
        NavMeshHit hit;

        if (NavMesh.SamplePosition(randomPoint, out hit, Random.Range(0f, walkRadius), 1))
        {
            //Debug.DrawLine(transform.position, randomDir, Color.red, 30f);
            agent.SetDestination(hit.position);
        }
    }
}

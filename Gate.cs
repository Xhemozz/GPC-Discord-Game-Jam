using UnityEngine;

public class Gate : MonoBehaviour
{
    private Animator animator;

    private bool isTriggered = false;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") || isTriggered == false)
        {
            animator.SetBool("Open", true);
            animator.SetBool("Closed", false);
            isTriggered = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Open", false);
            animator.SetBool("Closed", true);
        }
        isTriggered = false;
    }
}

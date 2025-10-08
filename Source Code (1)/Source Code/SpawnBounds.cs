using Unity.Cinemachine;
using UnityEngine;

public class SpawnBounds : MonoBehaviour
{
    public Vector3 finalPos;

    private void Start()
    {
        SpawnInArea();
    }
    private void SpawnInArea()
    {
        float max = 50f;
        float length = Random.Range(transform.position.x, max);
        float width = Random.Range(transform.position.z, max);

        Vector3 location = new Vector3(length, 0, width);
        finalPos = location;
    }
}

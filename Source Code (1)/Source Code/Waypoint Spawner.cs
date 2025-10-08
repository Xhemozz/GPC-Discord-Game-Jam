using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WaypointSpawner : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public GameObject prefab;
    private float timer;
    private bool isSpawning;


    // Update is called once per frame
    void Update()
    {
        if (!isSpawning)
            timer += Time.deltaTime;
        if (timer >= 2)
            SpawnCat();
    }

    void SpawnCat()
    {
        isSpawning = true;
        timer = 0f;

        for (int i = 0; i < spawnPoints.Count; i++)
        {
            var point = spawnPoints[i].GetComponent<SpawnBounds>().finalPos;
            for(int j = 0; j < spawnPoints.Count; j++)
            {
                CreateCat(point);
            }
            
        }
    }
    void CreateCat(Vector3 pos)
    {

        GameObject clone = Instantiate(prefab, pos, Quaternion.identity);
        clone.GetComponent<CatAI>().followTarget = GameObject.Find("Mouse").transform;
    }
}

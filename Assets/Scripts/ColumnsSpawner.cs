using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnsSpawner : MonoBehaviour
{

    public GameObject ColumnPrefab;
    public float minY, maxY;
    float timer;
    public float maxTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (ColumnPrefab == null)
        {
            Debug.LogError("Column Prefab is not assigned!");
            return;
        }

        SpawnColumn();
    }

    // Update is called once per frame
    void Update()
    {
        if (ColumnPrefab == null) return; 

        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            SpawnColumn();
            timer = 0;
        }

    }

    void SpawnColumn()
    {
        float RandYPos = Random.Range(minY, maxY);

        if (ColumnPrefab != null)
        {
            GameObject newColumn = Instantiate(ColumnPrefab);
            newColumn.transform.position = new Vector2(transform.position.x, RandYPos);
        }
        else
        {
            Debug.LogError("Column Prefab is not assigned!");
        }
    }
   
}

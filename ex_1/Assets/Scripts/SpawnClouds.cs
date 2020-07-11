using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    public GameObject  prefabClouds;
    float       count = 10;
    float       x;
    // Start is called before the first frame update
    void Start()
    {
        x = prefabClouds.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 leftBorder = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
       // float leftBorder = Camera.main.ViewportToWorldPoint(Vector3(0, 0, prefabClouds.transform.position.z)).x;
        if (count >= 10)
        {
            Instantiate(prefabClouds, new Vector3((leftBorder.x - prefabClouds.transform.position.x) * 2, Random.Range(-1f , 1f), prefabClouds.transform.position.z), Quaternion.identity);
            count = 0;
        }
        count += Time.deltaTime;
    }
}

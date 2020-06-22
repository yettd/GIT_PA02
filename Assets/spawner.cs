using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] ob;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0.1f, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawn()
    {
        float x = 0;
        x = Random.Range(-1.5f, 1.6f);
        transform.position = new Vector3(x,transform.position.y,transform.position.z);
        Instantiate(ob[Random.Range(0, 4)], transform.position, Quaternion.identity);
    }
}

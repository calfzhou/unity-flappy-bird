using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject column;
    public float cooldown = 2f;
    float nextSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isActive && Time.time > nextSpawn) {
            nextSpawn = Time.time + cooldown;
            Vector3 pos = transform.position;
            pos.y += Random.Range(-3f, 3f);
            Instantiate(column, pos, transform.rotation);
        }
    }
}

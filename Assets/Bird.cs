using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D rig;
    public float upForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isActive && Input.GetKeyDown("space")) {
            rig.AddForce(Vector2.up * upForce);
        }
    }
}

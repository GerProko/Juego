using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    float Speed =0.1f;
    int rotation = 3;
    //private Component script;
    public string enemy;
    public Transform Spawn;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //script = gameObject.GetComponent<SpawnPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * -Speed);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotation, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotation, 0);
        }
    }
    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == enemy)
        {
            Destroy(gameObject);
            Instantiate(player, Spawn);
            //gameObject.GetComponent<SpawnPoint>();
            //script = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPieces : MonoBehaviour
{

    float h;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Goofy();
        } else
        {
            Moving();
        }
    }

    void Goofy()
    {
        h = Random.Range(0.5f, 5);
        transform.position = new Vector3(transform.position.x,h,transform.position.z);
    }

    void Moving()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x+1,1,transform.position.z+1);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x-1,1,transform.position.z+1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x-1,1,transform.position.z-1);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x+1,1,transform.position.z-1);
        }
    }
}

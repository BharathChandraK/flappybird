using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    public float speed = 5f;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
        if(transform.position.x<-15f)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
    }
}

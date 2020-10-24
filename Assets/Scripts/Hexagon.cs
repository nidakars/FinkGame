using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    
    public Rigidbody2D rgb;
    public float _speed = 3f;
 

    void Start()
    {
        rgb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * _speed * Time.deltaTime;
        if (transform.localScale.x <=.05f)
        {
            Destroy(gameObject);
        }
       
    }
}

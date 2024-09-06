using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidePlatform : MonoBehaviour
{
    [SerializeField] float speed;
    private float startLocation;
    private float endLocation;
    [SerializeField] float distance;
    private Vector3 direction = Vector3.left;
    private bool hasCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        startLocation = transform.position.x;

        endLocation = startLocation - distance;
    }

    // Update is called once per frame
    void Update()
    {
        if (hasCollided)
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }

        if (transform.position.x <= endLocation)
        {
            direction = Vector3.right;
        }
        if (transform.position.x >= startLocation)
        {
            direction = Vector3.left;
        }


    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hasCollided = true;
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coint : MonoBehaviour
{

    [SerializeField] int pointValue;
    private bool hasCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasCollided)
        {
            UIManager.instance.IncreaseScore(pointValue);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            hasCollided = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunlightScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collides");
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

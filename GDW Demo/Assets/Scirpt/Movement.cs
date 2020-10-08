using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    float speedcontrol = 12f;

    // Update is called once per frame
    void Update()
    {
        Vector3 wasd = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        transform.position = transform.position + wasd * Time.deltaTime * speedcontrol;
    }
}

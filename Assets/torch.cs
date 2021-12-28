using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch : MonoBehaviour
{
    public GameObject Tor;
    public bool _torch = false;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Torch") && _torch == false)
        {
            _torch = true;
            

        }
        if (Input.GetButtonDown("Torch_") && _torch == true)
        {
            _torch = false;
            

        }
    }
}

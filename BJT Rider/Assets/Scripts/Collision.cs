using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject scoreCanvas;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected");
        scoreCanvas.SetActive(true); 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

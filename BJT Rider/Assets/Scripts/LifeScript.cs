using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeScript : MonoBehaviour
{
    public Image healthBar;
    public int jaan = 4;
    private float decrement = 0.25F;//
    public GameObject ScoreCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = jaan * decrement;
        if(jaan==0){
            ScoreCanvas.SetActive(true);
        }
    }
}

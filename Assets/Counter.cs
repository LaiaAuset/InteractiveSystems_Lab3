using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Counter : MonoBehaviour
{
    // Start is called before the first frame update
    private int count;
    public Text countText;
    public Text winText;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win! :)";
        }
    } 
    }

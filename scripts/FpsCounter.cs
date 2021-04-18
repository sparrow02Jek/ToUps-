using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FpsCounter : MonoBehaviour
{
    public TextMeshProUGUI FpsText;
    
    void Start () {
       
    }
       
    // Update is called once per frame
    void Update () {
       
    }
    public void OnGUI () 
    {
        
        float fps = 1 / Time.unscaledDeltaTime;
        fps = Mathf.Round(fps);
        FpsText.text = fps.ToString();
        
    }
}



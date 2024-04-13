using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class sss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public TMPro.TextMeshProUGUI text;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("k"))
        {
            text.text = string.Format("너무 더워요.");
            
        }
        if (Input.GetKey("l"))
        {
            text.text = string.Format("흠");

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UINumber : MonoBehaviour
{
    public Image img;
    [Range(0,9)]
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

  
  
}

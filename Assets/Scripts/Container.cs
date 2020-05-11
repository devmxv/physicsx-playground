using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    private Color _containerColor;
    //private List<Color> _colorOptions = new List<Color>();
    private Color[] _colorOptions;

    

    // Start is called before the first frame update
    void Start()
    {
        //GetContainerColor();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    public void GetContainerColor()
    {
        int i = 0;
        //---Loop through each container
        //---Get the color
        //---Save the color to list
        foreach (Transform child in transform)
        {
            _containerColor = child.GetComponent<MeshRenderer>().material.color;
            _colorOptions[i++] = _containerColor;
            //_colorOptions.Add(_containerColor);
            
            
        }

        

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorClick : MonoBehaviour
{
    public Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chosenColor()
    {
        int chooseColor = Random.Range(0, 3);
        if(chooseColor == 0)
        {
            renderer.material.color = Red();
        }
        else if(chooseColor == 1)
        {
            renderer.material.color = Blue();
        }
        else
        {
            renderer.material.color = Green();
        }
    }

    Color Red()
    {
        return Color.red;
    }

    Color Blue()
    {
        return Color.blue;
    }

    Color Green()
    {
        return Color.green;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    Color color;
    public float red;
    public float blue;
    public float green;
    public float alpha;

    public Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        alpha = 1;
    }

    // Update is called once per frame
    void Update()
    {
        color = new Color(red, green, blue, alpha);
        renderer.material.color = color;
    }
}

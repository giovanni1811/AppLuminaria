using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSlider : MonoBehaviour {

    public SeletorSlider selet;
    public CircleSliderCenter centro;
    public bool emCima;

	// Use this for initialization
	void Start () {
        emCima = false;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OnMouseOver()
    {
        if (!centro.emCima)
        {
            emCima = true;
        }
    }
    public void OnMouseExit()
    {
        emCima = false;
    }

    


}

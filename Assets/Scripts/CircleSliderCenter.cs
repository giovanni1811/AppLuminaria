using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSliderCenter : MonoBehaviour {

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
        emCima = true;
    }
    public void OnMouseExit()
    {
        emCima = false;
    }
}

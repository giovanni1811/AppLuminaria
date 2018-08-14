using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeletorCores : MonoBehaviour {

    public bool emCima;
    public SeletorSlider selet;

	// Use this for initialization
	void Start () {
        emCima = false;
	}
	
	// Update is called once per frame
	void Update() {
        
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

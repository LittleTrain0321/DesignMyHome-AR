using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour {
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;
    public GameObject c7;
    public GameObject cube;
    public Slider slider;
   
    // Use this for initialization
    void Start () {
       
       
    }
	void Fall()
    {
        slider.value = 0;
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        c5.SetActive(false);
        c6.SetActive(false);
        c7.SetActive(false);
    }
	// Update is called once per frame
	
    public void Controll1(){

        Fall();
        
        c1.SetActive(true);
        
        cube = c1;
       
        
    }
    public void Controll2()
    {
        Fall();
        c2.SetActive(true);
        cube = c2;
    }
    public void Controll3()
    {
        Fall();
        c3.SetActive(true);
        cube = c3;
    }
    public void Controll4()
    {
        Fall();
        c4.SetActive(true);
        cube = c4;
    }
    public void Controll5()
    {

        Fall();
        c5.SetActive(true);
        cube = c5;
    }
    public void Controll6()
    {
        Fall();
        c6.SetActive(true);
        cube = c6;
    }
    public void Controll7()
    {
        Fall();
        c7.SetActive(true);
        cube = c7;
    }
    public void Sccale()
    {
        cube.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
    }

}

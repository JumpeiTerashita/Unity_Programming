using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {
    [SerializeField]
    GameObject Cube;

	// Use this for initialization
	void Start () {
       
       
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Debug.Log("i = "+i+ " j = " + j);
                GameObject InstObj = Instantiate(Cube);
                InstObj.transform.position = new Vector3(j,-i,0);
            }
                
            

            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

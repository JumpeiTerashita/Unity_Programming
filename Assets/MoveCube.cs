using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {
    Vector3 NowPos;

    [SerializeField]
    float speed;
    [SerializeField]
    float accelMagnitude;

    // Use this for initialization
    void Start () {
        NowPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        speed *= accelMagnitude;

        

        NowPos.x += speed;
        transform.position = NowPos;
	}

    public void ButtonPushed()
    {
        
            speed *= -1;
        
    }
}

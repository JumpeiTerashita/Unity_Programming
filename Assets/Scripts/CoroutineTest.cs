using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Start1");
        StartCoroutine(TestCor());
        Debug.Log("Start2");
    }
	
	IEnumerator TestCor()   
    {
        yield return null;  //  次フレームまで待機
        Debug.Log("Test1");

        //  yield break;    //  returnみたいな挙動
        //  yield return new WaitForSeconds(2f) //  2f待つ
        //  yield return StartCoroutine(TestCor1);  //  TestCor1が終わるまで待つ
    }

    IEnumerator TestCor1()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("TestCol1");
        //  StartCoroutine(TestCor1()); //  自分を発火→無限ループが実現できる
    }


}

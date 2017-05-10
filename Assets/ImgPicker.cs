using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ImgPicker : MonoBehaviour {

   

	// Use this for initialization
	void Start () {

        StartCoroutine(GetPicture());

        
    }
	
	

    IEnumerator GetPicture()
    {
        WWW request = new WWW("http://ezlog.biz/wp-content/uploads/2015/05/Unity-Logo.png");

        yield return request;

        if (!string.IsNullOrEmpty(request.error))
        {
            Debug.Log(request.error);
        }
        else
        {
            // webサーバから取得した画像をRaw Imagで表示する
            RawImage rawImage = GetComponent<RawImage>();
            rawImage.texture = request.textureNonReadable;

            //ピクセルサイズ等倍に
            //rawImage.SetNativeSize();
        }
    
    }
}

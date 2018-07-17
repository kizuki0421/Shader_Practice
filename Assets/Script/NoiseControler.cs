using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoiseControler : MonoBehaviour {

	IEnumerator GeneratePluseNoise(){
		for(int i = 0;i <= 180; i += 30){
			GetComponent<Image>().material.SetFloat("_Amount",0.2f*Mathf.Sin(i*Mathf.Deg2Rad));
			yield return null;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){
			StartCoroutine(GeneratePluseNoise());
		}
	}
}

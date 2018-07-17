using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DepthControl : MonoBehaviour {

	public Material mat;
	void Start () {
		GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
	}
	
	// Update is called once per frame
	public void OnRenderImage(RenderTexture source, RenderTexture dest){
		Graphics.Blit(source,dest,mat);
	}
}

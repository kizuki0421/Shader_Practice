using UnityEngine;
using System.Collections;

public class PostEffect2 : MonoBehaviour {

	public Material wipeCircle;

	void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		Graphics.Blit (src, dest, wipeCircle);
	}
}

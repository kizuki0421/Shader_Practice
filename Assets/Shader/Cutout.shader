﻿Shader "Custom/Cutout" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		
	}
	SubShader {
		Tags { "Queue"="Geometry-1" }

		pass{
			Zwrite On
			ColorMask 0
		}

	}
}

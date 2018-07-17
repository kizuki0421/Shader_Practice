﻿Shader "Custom/NewSurfaceShader" {
	/*Properties{
    _BaseColor("BaseColor",Color) = (1,1,1,1)
    }*/
	SubShader {
		Tags { "Queue" = "Transparent" }
		LOD 200

		CGPROGRAM
  		#pragma surface surf Standard alpha:fade
		#pragma target 3.0

	      
		struct Input {
			float2 uv_MainTex;
		};
        fixed4 _BaseColor;
		void surf (Input IN, inout SurfaceOutputStandard o) {
            o.Albedo =fixed4(1,1,1,1);
            o.Alpha = 0.6;
		}
		ENDCG
	}
	FallBack "Diffuse"
}

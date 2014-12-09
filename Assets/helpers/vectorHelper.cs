using UnityEngine;
using System.Collections;

public class vectorHelper : MonoBehaviour {

	public static Vector2 RotateVector(Vector2 inputVector, float angle)
	{	
		float sin = Mathf.Sin(angle * Mathf.Deg2Rad);
		float cos = Mathf.Cos(angle * Mathf.Deg2Rad);
		
		float tx = inputVector.x;
		float ty = inputVector.y;
		inputVector.x = (cos * tx) - (sin * ty);
		inputVector.y = (sin * tx) + (cos * ty);
		return inputVector;
			
	}
}

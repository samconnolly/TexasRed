using UnityEngine;
using System.Collections;

public class InputHelper : MonoBehaviour
{

	public static int GetDirectionKey()
	{

		if (Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { return 1; }

		else if (Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { return -1; }

		else {return 0;} 
	} 
	public static bool GetThrottle()
	{
				if (Input.GetKey (KeyCode.Space)) {
						return true;
				} else {
						return false;
				}
		}
	public static bool GetReverse()
	{
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			return true;
		} else {
			return false;
		}
	}
}
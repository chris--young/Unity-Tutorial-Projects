using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	void Update ()
	{
		transform.Rotate (new Vector3 (10, 15, 45) * Time.deltaTime);
	}
}

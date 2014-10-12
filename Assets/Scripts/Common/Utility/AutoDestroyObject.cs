using UnityEngine;
using System.Collections;

public class AutoDestroyObject : MonoBehaviour 
{
	public float timeBeforeObjectDestroys;
	
	void Start () {
		// the function destroyGO() will be called in timeBeforeObjectDestroys seconds
		Invoke("destroyGO",timeBeforeObjectDestroys);
	}
	
	void destroyGO () {
		// destroy this gameObject
		Destroy(gameObject);
	}
}

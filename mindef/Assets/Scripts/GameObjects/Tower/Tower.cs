using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

	[SerializeField]
	private TowerRuntimeSet towersRef = null;

	public TowerInfo info;


	void OnEnable(){
		GetComponent<CircleCollider2D> ().radius = info.Range;
		towersRef.Add (this);
	}

	void OnDisable(){
		towersRef.Remove (this);
	}
}


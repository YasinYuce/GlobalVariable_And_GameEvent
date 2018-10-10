using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

	#region Variables
	[SerializeField]
	private TowerRuntimeSet towersRef = null;

	public TowerInfo info;
	#endregion

	#region initialize
	void Awake(){
		coll = GetComponent<CircleCollider2D> ();
	}
	#endregion

	#region info bindings
	private CircleCollider2D coll = null;
	[SerializeField]
	private GameObject rangeCircle = null;

	void initializeInfoBindings(){
		coll.radius = info.Range;
		rangeCircle.transform.localScale = Vector3.one * info.Range * 2f;
	}
	#endregion

	#region Unity callbacks
	void OnEnable(){
		initializeInfoBindings ();
		towersRef.Add (this);
	}

	void OnDisable(){
		towersRef.Remove (this);
	}
	#endregion
}
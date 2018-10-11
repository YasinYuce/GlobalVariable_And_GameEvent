using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Tower : MonoBehaviour {

	#region Variables
	[SerializeField]
	private TowerRuntimeSet towersRef = null;

	[SerializeField]
	private TowerInfo info = null;
	public TowerInfo PrefabInfo { get { return info;} }

	[System.NonSerialized]
	public TowerInfo Info;
	#endregion

	#region initialize
	void Awake(){
		coll = GetComponent<CircleCollider2D> ();
	}
	#endregion

	#region info And info bindings
	private CircleCollider2D coll = null;
	[SerializeField]
	private GameObject rangeCircle = null;

	void initializeInfo(){
		Info = ScriptableObject.CreateInstance<TowerInfo> ();
		info.FillInstance (Info);
	}

	void initializeInfoBindings(){
		coll.radius = Info.Range;
		rangeCircle.transform.localScale = Vector3.one * Info.Range * 2f;
	}
	#endregion

	#region Unity callbacks
	void OnEnable(){
		initializeInfo ();
		initializeInfoBindings ();
		towersRef.Add (this);
	}

	void OnDisable(){
		towersRef.Remove (this);
	}
	#endregion
}
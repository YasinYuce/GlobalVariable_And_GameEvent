using UnityEngine;

public abstract class AddTransform : BaseAdd 
{
	[SerializeField]
	protected Vector3 speed;

	protected Vector3 cachedValue;
	protected Transform myTransform;

	public virtual void Awake(){
		myTransform = transform;
	}

	public virtual void OnEnable(){
		UpdateAdds.Instance.Add (this);
	}

	public virtual void OnDisable(){
		if(UpdateAdds.InstanceExist)
			UpdateAdds.Instance.Remove (this);
	}
}

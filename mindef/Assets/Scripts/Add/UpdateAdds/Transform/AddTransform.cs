using UnityEngine;

public abstract class AddTransform : BaseAdd 
{
	public Vector3Reference Speed;

	protected Vector3 cachedValue;
	protected Transform myTransform;

	public virtual void Awake(){
		myTransform = transform;
	}

	public virtual void OnEnable(){
		UpdateAdds updator = GetComponentInParent<UpdateAdds> ();
		if(updator != null)
			updator.Add (this);
	}

	public virtual void OnDisable(){
		UpdateAdds updator = GetComponentInParent<UpdateAdds> ();
		if (updator != null)
			updator.Remove (this);
	}
}

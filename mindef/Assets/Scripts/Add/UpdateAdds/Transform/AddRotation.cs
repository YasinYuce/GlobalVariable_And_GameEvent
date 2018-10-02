using UnityEngine;

public class AddRotation : AddTransform 
{
	public override void Awake(){
		base.Awake ();
		cachedValue = myTransform.rotation.eulerAngles;
	}

	public override void Action ()
	{
		cachedValue += Speed.Value;
		myTransform.rotation = Quaternion.Euler (cachedValue);
	}
}

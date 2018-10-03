using UnityEngine;

public class AddPingPongRotation : AddRotation 
{
	[SerializeField]
	private int changeIteration = 30;

	int count;
	bool turned;
	public override void Action ()
	{
		if (turned)
			plusTheValue ();
		else
			minusTheValue ();
	}

	void plusTheValue(){
		cachedValue += Speed.Value;
		myTransform.rotation = Quaternion.Euler (cachedValue);
		count--;
		if (count == 0)
			turned = false;
	}

	void minusTheValue(){
		cachedValue -= Speed.Value;
		myTransform.rotation = Quaternion.Euler (cachedValue);
		count++;
		if (count == changeIteration)
			turned = true;
	}
}
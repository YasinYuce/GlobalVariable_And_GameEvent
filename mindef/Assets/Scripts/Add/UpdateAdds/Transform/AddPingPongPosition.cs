using UnityEngine;

public class AddPingPongPosition : AddTransform 
{
	[SerializeField]
	private int changeIteration = 15;

	public override void Awake ()
	{
		base.Awake ();
		cachedValue = myTransform.localPosition;
	}

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
		myTransform.localPosition = cachedValue;
		count--;
		if (count == 0)
			turned = false;
	}

	void minusTheValue(){
		cachedValue -= Speed.Value;
		myTransform.localPosition = cachedValue;
		count++;
		if (count == changeIteration)
			turned = true;
	}
}

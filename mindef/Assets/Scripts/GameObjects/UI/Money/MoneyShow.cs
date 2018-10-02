using UnityEngine;

public class MoneyShow : FloatRefShowUI 
{
	void Awake(){
		value.Value = 50f;
		Show ();
	}
	
}

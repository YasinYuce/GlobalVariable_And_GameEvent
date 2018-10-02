using UnityEngine;
using UnityEngine.UI;

public class FloatRefShowUI : MonoBehaviour 
{
	[SerializeField]
	protected FloatReference value = null;

	[SerializeField]
	protected Text valueText = null;


	public void Show(){
		valueText.text = value.Value.ToString ();
	}
}

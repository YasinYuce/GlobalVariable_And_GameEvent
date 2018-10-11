using UnityEngine;
using UnityEngine.UI;

public class MoneyChangeResponse : MonoBehaviour, IResponse
{
	[SerializeField]
	protected FloatReference value = null;

	[SerializeField]
	protected Text valueText = null;

	void Awake(){
		value.Value = 50f;
		Response ();
	}

	#region IResponse implementation

	public void Response(){
		valueText.text = value.Value.ToString ();
	}

	#endregion
}

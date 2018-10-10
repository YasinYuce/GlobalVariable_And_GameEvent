using UnityEngine;

public abstract class InputManager : MonoBehaviour 
{
	protected virtual int layerMask { get { return 0; } }

	protected virtual void Update(){
		throw new System.NotImplementedException ();
	}
}

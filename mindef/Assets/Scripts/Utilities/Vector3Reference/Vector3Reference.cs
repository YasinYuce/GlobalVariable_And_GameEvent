using UnityEngine;

[System.Serializable]
public class Vector3Reference 
{
	[SerializeField]
	private bool UseConstant = false;

	[SerializeField]
	private Vector3 ConstantValue = Vector3.zero;

	[SerializeField]
	private Vector3Variable Variable = null;

	public Vector3 Value { get{ return UseConstant ? ConstantValue : Variable.Value; } }
}

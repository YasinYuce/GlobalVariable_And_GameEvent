using UnityEngine;

[System.Serializable]
public class FloatReference 
{
	[SerializeField]
	private bool UseConstant = false;
	[SerializeField]
	private float ConstantValue = 0f;
	[SerializeField]
	private FloatVariable Variable = null;

	public float Value { get{ return UseConstant ? ConstantValue : Variable.Value; } set{ Variable.Value = UseConstant ? Variable.Value : value; }}
}

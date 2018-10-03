using UnityEngine;
using UnityEngine.Serialization;

public abstract class VariableReference{
	public abstract bool UseReferenceVariable { get;}
}

[System.Serializable]
public class VariableReference<Type ,VariableReferenceType> : VariableReference
	where VariableReferenceType : GlobalVariable<Type> 
{

	[SerializeField]
	private bool useReference = false;
	[SerializeField]
	private Type constantValue = default(Type);

	[SerializeField, FormerlySerializedAs("globalVariableReference")]
	private VariableReferenceType variable = null;

	public override bool UseReferenceVariable {
		get {
			return useReference;
		}
	}

	public Type Value { get{ return useReference ? variable.Value : constantValue; } 
		set{ 
			if (useReference)
				variable.Value = value;
			else
				constantValue = value; }
	}
}

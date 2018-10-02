using UnityEngine;

public static class FloatExtend 
{
	public static bool IsBiggerOrEqualThan(this float f1, float f2){
		if (f1 >= f2)
			return true;
		return false;
	}

}

using UnityEngine;
using System.Collections.Generic;

public static class TransformExtend 
{

	public static Transform FindClosestTransformToGivenPoint (this Transform[] _transforms, Vector2 Point){
		float lowestDistance = Mathf.Infinity;
		int lowestDistanceIndex = -1;
		for (int i = 0; i < _transforms.Length; i++) {
			//check if its the lowest value
			float distance = Vector2.Distance(_transforms[i].position, Point);
			if (distance < lowestDistance) {
				//if it is, take new lowest value and its index for return.
				lowestDistance = distance;
				lowestDistanceIndex = i;
			}
		}
		if (lowestDistanceIndex < 0)
			return null;
		return _transforms [lowestDistanceIndex];
	}

	public static Transform FindClosestTransformToGivenPoint (this List<Transform> _transforms, Vector2 Point){
		float lowestDistance = Mathf.Infinity;
		int lowestDistanceIndex = -1;
		for (int i = 0; i < _transforms.Count; i++) {
			//check if its the lowest value
			float distance = Vector2.Distance(_transforms[i].position, Point);
			if (distance < lowestDistance) {
				//if it is, take new lowest value and its index for return.
				lowestDistance = distance;
				lowestDistanceIndex = i;
			}
		}
		if (lowestDistanceIndex < 0)
			return null;
		return _transforms [lowestDistanceIndex];
	}
}

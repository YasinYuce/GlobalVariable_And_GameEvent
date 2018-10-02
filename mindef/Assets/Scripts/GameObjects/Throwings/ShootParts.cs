using UnityEngine;
public class ShootParts : MonoBehaviour {
	public Transform MyTransform;
	Vector3 Temp = new Vector3 (0f, -90f, 0f);
	void FixedUpdate(){
		Temp.z += 15;
		MyTransform.localRotation = Quaternion.Euler (Temp);
	}
}

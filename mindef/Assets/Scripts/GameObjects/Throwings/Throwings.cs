using UnityEngine;
using System.Collections;
public class Throwings : MonoBehaviour {

//	float Damage;
//	internal Transform Owner, Target;
//	//Vector3 Angles = InputManager.zero;
//	internal int x;
//	//float Plus = 15;
//	Effect Effectt;
//	public Transform[] MyTrails;
//	float[] ResetZs;
//	int Count,TargetValue;
//	internal bool SetStart(Transform Ownr,Transform Trgt,float _Damage,Effect _Effect){
//		IsTargetBoxOfMonster = false;
//		Owner = Ownr;
//		Effectt = _Effect;
//		Target = Trgt;
//		Trgt.GetComponent<Monster> ().ThrowedToMe.Add(this);
//		x = 0;
//		Damage = _Damage;
//		MyTransform.LookAt (Trgt);
//		if (Count == 0) {
//			Count = MyTrails.Length;
//			ResetZs = new float[Count];
//			for (int i = 0; i < Count; i++) {
//				ResetZs [i] = MyTrails [i].localPosition.z;
//			}
//		}
//		for (int i = 0; i < Count; i++) {
//			MyTrails [i].parent = PoolManager.Stat.GlobalParent;
//		}
//		TargetValue = (int)(Vector3.Distance (MyTransform.position, Target.position) * 7f);
//		gameObject.SetActive (true);
//		return Trgt.GetComponent<Monster> ().TakeVisionHpDamage (_Damage);
//	}
//	bool IsTargetBoxOfMonster;
//	internal bool SetStartBoxOfMonster(Transform Ownr,Transform Trgt,float _Damage){
//		IsTargetBoxOfMonster = true;
//		Owner = Ownr;
//		Target = Trgt;
//		Trgt.GetComponent<BoxOfMonster> ().ThrowedToMe.Add(this);
//		x = 0;
//		Damage = _Damage;
//		MyTransform.LookAt (Trgt);
//		if (Count == 0) {
//			Count = MyTrails.Length;
//			ResetZs = new float[Count];
//			for (int i = 0; i < Count; i++) {
//				ResetZs [i] = MyTrails [i].localPosition.z;
//			}
//		}
//		for (int i = 0; i < Count; i++) {
//			MyTrails [i].parent = PoolManager.Stat.GlobalParent;
//		}
//		TargetValue = (int)(Vector3.Distance (MyTransform.position, Target.position) * 7f);
//		gameObject.SetActive (true);
//		return Trgt.GetComponent<BoxOfMonster> ().TakeVisionHpDamage (_Damage);
//	}
//	internal void UpdateThrowing(){
//		MyTransform.LookAt(Target);
//		MyTransform.position = Vector3.MoveTowards(MyTransform.position,Target.position,Vector3.Distance(MyTransform.position,Target.position)/(TargetValue-x));
//		for (int i = Count-1; i > 0; i--) {
//			MyTrails [i].position = MyTrails[i-1].position;
//		}
//		MyTrails [0].position = MyTransform.position;
//		x++;
//		if (x==TargetValue) {
//			MyTransform.position = Target.position;
//		}
//		if (MyTransform.position == Target.position) {
//			gameObject.SetActive (false);
//			ResetTrail ();
//			if (IsTargetBoxOfMonster) {
//				Target.GetComponent<BoxOfMonster> ().ThrowedToMe.Remove(this);
//			} else {
//				Target.GetComponent<Monster> ().ThrowedToMe.Remove(this);
//			}
//			if (!Target.gameObject.activeSelf) {
//				Reset ();
//				return;
//			}
//			if (IsTargetBoxOfMonster) {
//				if (Target.GetComponent<BoxOfMonster> ().TakeDamage (Damage)) {
//					gameObject.SetActive (false);
//				}
//			} else {
//				if (Target.GetComponent<Monster> ().TakeDamage (Damage,Effectt,false)) {
//					Owner.GetComponent<Tower> ().GainExp (Target.GetComponent<Monster> ().HP);
//					Reset ();
//				}
//			}
//			//Vurdu
//			return;
//		}
//	}
//	internal void ResetTrail(){
//		for (int i = 0; i < Count; i++) {
//			MyTrails [i].parent = MyTransform;
//		}
//		Vector3 Pos = Vector3.zero;
//		for (int i = 0; i < Count; i++) {
//			Pos.z = ResetZs [i];
//			MyTrails [i].localPosition = Pos;
//			MyTrails [i].localRotation = Quaternion.Euler (0f,-90f,0f);
//		}
//	}
//	internal void Reset(){
//		if (!IsTargetBoxOfMonster) {
//			Owner.GetComponent<Tower>().SomeSortOfReset(Target.GetComponent<Monster> ());
//		}
//		gameObject.SetActive (false);
//	}
}

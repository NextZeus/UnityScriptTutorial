using UnityEngine;

public class Level : MonoBehaviour {

	public int experience;
	public int level{
		get {return experience / 750;}
	}
}

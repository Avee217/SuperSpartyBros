using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlatform : MonoBehaviour {

	Animator _animator;
	public bool trap;

	void Awake () 
	{
		_animator = GetComponent<Animator> ();
		if (_animator == null) // if Animator is missing
			Debug.LogError ("Animator component missing from this gameobject");
		trap = false;

	}

		
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			trap = true;
			_animator.SetBool("TrapTrigger",trap);
		}

	}


}

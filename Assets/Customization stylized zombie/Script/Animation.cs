using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Animation : MonoBehaviour {
	public Text Label_animation;
	public string[] Anim_mas;
	int i;
	 Animator anim;
	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();
		anim.Play("Idle1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void checkAnim (int q){
		if (q == 1) {
			i++;
			if (i < Anim_mas.Length) {
				anim.Play (Anim_mas [i]);

			} else {
				i = 0;
				anim.Play (Anim_mas [i]);
			}
		}
		if (q == -1) {
			i--;
			if (i >= 0) {
				anim.Play (Anim_mas [i]);
			} else {
				i = 13;
				anim.Play (Anim_mas [i]);
			}
		}
		Label_animation.text = Anim_mas [i];
	}

}

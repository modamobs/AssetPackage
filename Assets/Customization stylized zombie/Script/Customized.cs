using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customized: MonoBehaviour {

	public bool Delete_invisible_object;
	public bool Customization_off;
	private int ran;
	public GameObject[] helmet;
	public bool Knight_helmet;
	public bool Peasant_helmet;
	public bool Warrior_helmet;
	public bool Random_helmet;
	private GameObject helmet_active;

	public GameObject[] body;
	public bool Zombie_body;
	public bool Knight_jacket;
	public bool Peasant_jacket;
	public bool Warrior_jacket;
	public bool Random_jacket;
	private GameObject body_active;

	public GameObject[] arms;
	public bool Zombie_arms;
	public bool Knight_glove;
	public bool Peasant_glove;
	public bool Warrior_glove;
	public bool Random_glove;
	private GameObject arms_active;

	public GameObject[] belt;
	public bool Knight_belt;
	public bool Peasant_belt;
	public bool Warrior_belt;
	public bool Random_belt;
	private GameObject belt_active;

	public GameObject[] legs;
	public bool Zombie_legs;
	public bool Knight_pants;
	public bool Peasant_pants;
	public bool Warrior_pants;
	public bool Random_pants;
	private GameObject legs_active;

	public GameObject[] feet;
	public bool Zombie_feet;
	public bool Knight_boot;
	public bool Peasant_boot;
	public bool Warrior_boot;
	public bool Random_boot;
	private GameObject feet_active;

	public GameObject[] weapons;
	public bool Club;
	public bool Axe;
	public bool Sword;
	public bool Random_weapons;
	private GameObject weapons_active;

	//equip label
	public Text Label_helmet;
	public Text Label_body;
	public Text Label_arms;
	public Text Label_belt;
	public Text Label_legs;
	public Text Label_feet;
	public Text Label_weapons;
	public Text Label_animation;

	//equip index
	private int h_i;
	private int bo_i;
	private int a_i;
	private int be_i;
	private int l_i;
	private int f_i;
	private int w_i;
	private int anim_i;

	// Use this for initialization
	void Start () {
		if (Customization_off==false) {
			Label_helmet.text = "helmet none";
			Label_body.text = "zombie body";
			Label_arms.text = "zombie arms";
			Label_belt.text = "belt none";
			Label_legs.text = "zombie legs";
			Label_feet.text = "zombie feet";
			Label_weapons.text = "weapons none";
			Label_animation.text = "idle1";
			h_i = -1;
			bo_i = 0;
			a_i = 0;
			be_i = -1;
			l_i = 0;
			f_i = 0;
			w_i = -1;
			anim_i = 0;	}
		
		Invis_all_object ();
		equipCheck ();

		if (Delete_invisible_object == true) {
			dellObject ();
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Invis_all_object(){
		for (int i = 0; i < helmet.Length; i++) {
			if (helmet_active != helmet [i]) {
				helmet [i].active = false;
			}
		}

		for (int i = 0; i < body.Length; i++) {
			if (body_active != body [i]) {
				body [i].active = false;
			}
		}
		for (int i = 0; i < arms.Length; i++) {
			if (arms_active != arms [i]) {
				arms [i].active = false;
			}
		}
		for (int i = 0; i < feet.Length; i++) {
			if (feet_active != feet [i]) {
				feet [i].active = false;
			}
		}
		for (int i = 0; i < legs.Length; i++) {
			if (legs_active != legs [i]) {
				legs [i].active = false;
			}
		}

		for (int i = 0; i < belt.Length; i++) {
			if (belt_active != belt [i]) {
				belt [i].active = false;
			}
		}
		for (int i = 0; i < weapons.Length; i++) {
			if (weapons_active != weapons [i]) {
				weapons [i].active = false;
			}
		}
	}
	void equipCheck (){
		//helmet on
		if (Knight_helmet == true) {
			equipHelmet (helmet [0]);
			h_i = 0;
		}
		if (Peasant_helmet == true) {
			equipHelmet (helmet [1]);
			h_i = 1;
		}
		if (Warrior_helmet == true) {
			equipHelmet (helmet [2]);
			h_i = 2;
		}
		if (Random_helmet == true) {
			ran = Random.Range (0, 4);
			if (ran < 3) {
				equipHelmet (helmet [ran]);
				h_i = ran;
			}
		}
		//body on
		if (Zombie_body == true) {
			equipBody (body [0]);
			bo_i = 0;
		}
		if (Knight_jacket == true) {
			equipBody (body [1]);
			bo_i = 1;
		}
		if (Peasant_jacket == true) {
			equipBody (body [2]);
			bo_i = 2;
		}
		if (Warrior_jacket == true) {
			equipBody (body [3]);
			bo_i = 3;
		}
		if (Random_jacket == true) {
			ran = Random.Range (0, 4);
			equipBody (body [ran]);
			bo_i = ran;
		}
		//arms on
		if (Zombie_arms == true) {
			equipArms (arms [0]);
			a_i = 0;
		}
		if (Knight_glove == true) {
			equipArms (arms [1]);
			a_i = 1;
		}
		if (Peasant_glove == true) {
			equipArms (arms [2]);
			a_i = 2;
		}
		if (Warrior_glove == true) {
			equipArms (arms [3]);
			a_i = 3;
		}
		if (Random_glove == true) {
			ran = Random.Range (0, 4);
			equipArms (arms [ran]);
			a_i = ran;
		}
		//belt on
		if (Knight_belt == true) {
			equipBelt (belt [0]);
			be_i = 0;
		}
		if (Peasant_belt == true) {
			equipBelt (belt [1]);
			be_i = 1;
		}
		if (Warrior_belt == true) {
			equipBelt (belt [2]);
			be_i = 2;
		}
		if (Random_belt == true) {
			ran = Random.Range (0, 4);
			if (ran < 3) {
				equipBelt (belt [ran]);
				be_i = ran;
			}
		}
		//legs on
		if (Zombie_legs == true) {
			equipLegs (legs [0]);
			l_i = 0;
		}
		if (Knight_pants == true) {
			equipLegs (legs [1]);
			l_i = 1;
		}
		if (Peasant_pants == true) {
			equipLegs (legs [2]);
			l_i = 2;
		}
		if (Warrior_pants == true) {
			equipLegs (legs [3]);
			l_i = 3;
		}
		if (Random_pants == true) {
			ran = Random.Range (0, 4);
			equipLegs (legs [ran]);
			l_i = ran;
		}

		//feet on
		if (Zombie_feet == true) {
			equipFeet (feet [0]);
			f_i = 0;
		}
		if (Knight_boot == true) {
			equipFeet (feet [1]);
			f_i = 1;
		}
		if (Peasant_boot == true) {
			equipFeet (feet [2]);
			f_i = 2;
		}
		if (Warrior_boot == true) {
			equipFeet (feet [3]);
			f_i = 3;
		}
		if (Random_boot == true) {
			ran = Random.Range (0, 4);
			equipFeet (feet [ran]);
			f_i = ran;
		}
		//weapon on
		if (Club == true) {
			equipWeapons (weapons [0]);
			w_i = 0;
		}
		if (Axe == true) {
			equipWeapons (weapons [1]);
			w_i = 1;
		}
		if (Sword == true) {
			equipWeapons (weapons [2]);
			w_i = 2;
		}
		if (Random_weapons == true) {
			ran = Random.Range (0, 3);
			equipWeapons (weapons [ran]);
			w_i = ran;
		}
	}
	void equipHelmet (GameObject helmet_on) {
		if (helmet_active != null) {
			helmet_active.active = false;
		}
		helmet_active = helmet_on;
		helmet_active.active = true;
	}
	void equipBody (GameObject body_on) {
		if (body_active != null) {
			body_active.active = false;
		}
		body_active = body_on;
		body_active.active = true;
	}
	void equipArms (GameObject arms_on) {
		if (arms_active != null) {
			arms_active.active = false;
		}
		arms_active = arms_on;
		arms_active.active = true;
	}
	void equipBelt (GameObject belt_on) {
		if (belt_active != null) {
			belt_active.active = false;
		}
		belt_active = belt_on;
		belt_active.active = true;
	}
	void equipLegs (GameObject legs_on) {
		if (legs_active != null) {
			legs_active.active = false;
		}
		legs_active = legs_on;
		legs_active.active = true;
	}
	void equipFeet (GameObject feet_on) {
		if (feet_active != null) {
			feet_active.active = false;
		}
		feet_active = feet_on;
		feet_active.active = true;
	}
	void equipWeapons (GameObject weapons_on) {
		if (weapons_active != null) {
			weapons_active.active = false;
		}
		weapons_active = weapons_on;
		weapons_active.active = true;
	}
		
	public void randomEquip (){
		//random helmet
		ran = Random.Range (-1, 3);
		if (ran < 3) {
			if (ran >= 0) {
				equipHelmet (helmet [ran]);
				h_i = ran;
			} else {if (helmet_active != null) {
					helmet_active.active = false;
					h_i = ran;
				}
			}
		}
		//random body
		ran = Random.Range (0, 4);
		if (ran < 4) {
			if (ran >= 0) {
				equipBody (body [ran]);
				bo_i = ran;
			} else {if (body_active != null) {
					body_active.active = false;
					bo_i = ran;
				}
			}
		}
		//random arms
		ran = Random.Range (0, 4);
		if (ran < 4) {
			if (ran >= 0) {
				equipArms (arms [ran]);
				a_i = ran;
			} else {if (arms_active != null) {
					arms_active.active = false;
					a_i = ran;
				}
			}
		}
		//random belt
		ran = Random.Range (-1, 3);
		if (ran < 3) {
			if (ran >= 0) {
				equipBelt (belt [ran]);
				be_i = ran;
			} else {if (belt_active != null) {
					belt_active.active = false;
					be_i = ran;
				}
			}
		}
		//random legs
		ran = Random.Range (0, 4);
		if (ran < 4) {
			if (ran >= 0) {
				equipLegs (legs [ran]);
				l_i = ran;
			} else {if (legs_active != null) {
					legs_active.active = false;
					l_i = ran;
				}
			}
		}
		//random feet
		ran = Random.Range (0, 4);
		if (ran < 4) {
			if (ran >= 0) {
				equipFeet (feet [ran]);
				f_i = ran;
			} else {if (feet_active != null) {
					feet_active.active = false;
					f_i = ran;
				}
			}
		}
		//random weapons
		ran = Random.Range (-1, 3);
		if (ran < 3) {
			if (ran >= 0) {
				equipWeapons (weapons [ran]);
				w_i = ran;
			} else {if (weapons_active != null) {
					weapons_active.active = false;
					w_i = ran;
				}
			}
		}

		labelEquip ();
	}



	void labelEquip () {
		if (h_i == -1) {
			Label_helmet.text = "helmet none";
		}	
		if (h_i == 0) {
			Label_helmet.text = "knight helmet";
		}	
		if (h_i == 1) {
			Label_helmet.text = "peasant helmet";
		}	
		if (h_i == 2) {
			Label_helmet.text = "warrior helmet";
		}	

		if (bo_i == 0) {
			Label_body.text = "zombie body";
		}	
		if (bo_i == 1) {
			Label_body.text = "knight jacket";
		}	
		if (bo_i == 2) {
			Label_body.text = "peasant jacket";
		}	
		if (bo_i == 3) {
			Label_body.text = "warrior jacket";
		}

		if (a_i == 0) {
			Label_arms.text = "zombie arms";
		}	
		if (a_i == 1) {
			Label_arms.text = "knight glove";
		}	
		if (a_i == 2) {
			Label_arms.text = "peasant glove";
		}	
		if (a_i == 3) {
			Label_arms.text = "warrior glove";
		}	

		if (be_i == -1) {
			Label_belt.text = "belt none";
		}	
		if (be_i == 0) {
			Label_belt.text = "knight belt";
		}	
		if (be_i == 1) {
			Label_belt.text = "peasant belt";
		}	
		if (be_i == 2) {
			Label_belt.text = "warrior belt";
		}	

		if (l_i == 0) {
			Label_legs.text = "zombie legs";
		}	
		if (l_i == 1) {
			Label_legs.text = "knight pants";
		}	
		if (l_i == 2) {
			Label_legs.text = "peasant pants";
		}	
		if (l_i == 3) {
			Label_legs.text = "warrior pants";
		}	

		if (f_i == 0) {
			Label_feet.text = "zombie feet";
		}	
		if (f_i == 1) {
			Label_feet.text = "knight boot";
		}	
		if (f_i == 2) {
			Label_feet.text = "peasant boot";
		}	
		if (f_i == 3) {
			Label_feet.text = "warrior boot";
		}	

		if (w_i == -1) {
			Label_weapons.text = "weapons none";
		}	
		if (w_i == 0) {
			Label_weapons.text = "club";
		}	
		if (w_i == 1) {
			Label_weapons.text = "axe";
		}	
		if (w_i == 2) {
			Label_weapons.text = "sword";
		}	
	}
	public void nextEquip (int x) {
		Invis_all_object ();
		//head_equip
		if (x==1) {
			h_i++;
			if (h_i==3){
				h_i = -1;	
			}
			if (h_i >= 0) {
				equipHelmet (helmet [h_i]);
			} else {helmet [2].active = false;
			}
		}
		if (x==-1) {
			h_i--;
			if (h_i==-2){
				h_i = 2;	
			}
			if (h_i >= 0) {
				equipHelmet (helmet [h_i]);
			} else {helmet [0].active = false;
			}
		}

		//body_equip
		if (x==2) {
			bo_i++;
			if (bo_i==4){
				bo_i = 0;	
			}
			if (bo_i >= 0) {
				equipBody (body [bo_i]);
			} else {body [3].active = false;
			}
		}
		if (x==-2) {
			bo_i--;
			if (bo_i==-1){
				bo_i = 3;	
			}
			if (bo_i >= 0) {
				equipBody (body [bo_i]);
			} else {body [0].active = false;
			}
		}

		//arms_equip
		if (x==3) {
			a_i++;
			if (a_i==4){
				a_i = 0;	
			}
			if (a_i >= 0) {
				equipArms (arms [a_i]);
			} else {arms [3].active = false;
			}
		}
		if (x==-3) {
			a_i--;
			if (a_i==-1){
				a_i = 3;	
			}
			if (a_i >= 0) {
				equipArms (arms [a_i]);
			} else {arms [0].active = false;
			}
		}

		//belt_equip
		if (x==4) {
			be_i++;
			if (be_i==3){
				be_i = -1;	
			}
			if (be_i >= 0) {
				equipBelt (belt [be_i]);
			} else {belt [2].active = false;
			}
		}
		if (x==-4) {
			be_i--;
			if (be_i==-2){
				be_i = 2;	
			}
			if (be_i >= 0) {
				equipBelt (belt [be_i]);
			} else {belt [0].active = false;
			}
		}


		//legs_equip
		if (x==5) {
			l_i++;
			if (l_i==4){
				l_i = 0;	
			}
			if (l_i >= 0) {
				equipLegs (legs [l_i]);
			} else {legs [3].active = false;
			}
		}
		if (x==-5) {
			l_i--;
			if (l_i==-1){
				l_i = 3;	
			}
			if (l_i >= 0) {
				equipLegs (legs [l_i]);
			} else {legs [0].active = false;
			}
		}

		//feet_equip
		if (x==6) {
			f_i++;
			if (f_i==4){
				f_i = 0;	
			}
			if (f_i >= 0) {
				equipFeet (feet [f_i]);
			} else {feet [3].active = false;
			}
		}
		if (x==-6) {
			f_i--;
			if (f_i==-1){
				f_i = 3;	
			}
			if (f_i >= 0) {
				equipFeet (feet [f_i]);
			} else {feet [0].active = false;
			}
		}

		//weapons_equip
		if (x==7) {
			w_i++;
			if (w_i==3){
				w_i = -1;	
			}
			if (w_i >= 0) {
				equipWeapons (weapons [w_i]);
			} else {weapons [2].active = false;
			}
		}
		if (x==-7) {
			w_i--;
			if (w_i==-2){
				w_i = 2;	
			}
			if (w_i >= 0) {
				equipWeapons (weapons [w_i]);
			} else {weapons [0].active = false;
			}
		}

		labelEquip ();
	}



	void dellObject () {

		//kill helmet
		for (int i = 0; i < helmet.Length; i++) {
			if (helmet_active != helmet [i]) {
				Destroy (helmet [i]);
			}
		}
		//kill body
		for (int i = 0; i < body.Length; i++) {
			if (body_active != body [i]) {
				Destroy (body [i]);
			}
		}
		//kill arms
		for (int i = 0; i < arms.Length; i++) {
			if (arms_active != arms [i]) {
				Destroy (arms [i]);
			}
		}
		//kill belt
		for (int i = 0; i < belt.Length; i++) {
			if (belt_active != belt [i]) {
				Destroy (belt [i]);
			}
		}
		//kill legs
		for (int i = 0; i < legs.Length; i++) {
			if (legs_active != legs [i]) {
				Destroy (legs [i]);
			}
		}
		//kill feet
		for (int i = 0; i < feet.Length; i++) {
			if (feet_active != feet [i]) {
				Destroy (feet [i]);
			}
		}
		//kill weapons
		for (int i = 0; i < weapons.Length; i++) {
			if (weapons_active != weapons [i]) {
				Destroy (weapons [i]);
			}
		}
	}
}

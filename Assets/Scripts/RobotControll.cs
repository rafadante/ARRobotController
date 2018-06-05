using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[ExecuteInEditMode]
public class RobotControll : MonoBehaviour {

	GameObject body, arm, hand, clawLow_base, clawTop_base, clawLow_mid, clawTop_mid, clawLow_tip, clawTop_tip;
	public Slider bodySlider, armSlider, handSlider, clawBaseSlider, clawMidSlider, clawTipSlider;

	void Start () {
		body = GameObject.Find("prop_robotArm_body");
		arm = GameObject.Find("prop_robotArm_arm");
		hand = GameObject.Find("prop_robotArm_hand");
		clawLow_base = GameObject.Find("prop_robotArm_clawLow_base");
		clawTop_base = GameObject.Find("prop_robotArm_clawTop_base");
		clawLow_mid = GameObject.Find("prop_robotArm_clawLow_mid");
		clawTop_mid = GameObject.Find("prop_robotArm_clawTop_mid");
		clawLow_tip = GameObject.Find("prop_robotArm_clawLow_tip");
		clawTop_tip = GameObject.Find("prop_robotArm_clawTop_tip");
	}
	
	public void BodyMovemet()
	{
		body.transform.localEulerAngles = new Vector3(0, bodySlider.value, 0);
	}

	public void ArmMovement()
	{
		arm.transform.localEulerAngles = new Vector3(0, 0, armSlider.value);
	}

	public void HandMovement()
	{
		hand.transform.localEulerAngles = new Vector3(0, 0, handSlider.value);
	}
	public void ClawBaseMovement()
	{
		clawLow_base.transform.localEulerAngles = new Vector3(0, 0, -clawBaseSlider.value);
		clawTop_base.transform.localEulerAngles = new Vector3(0, 0, clawBaseSlider.value);
	}

	public void ClawMidMovement()
	{
		clawLow_mid.transform.localEulerAngles = new Vector3(0, 0, -clawMidSlider.value);
		clawTop_mid.transform.localEulerAngles = new Vector3(0, 0, clawMidSlider.value);
	}

	public void ClawTipMovement()
	{
		clawLow_tip.transform.localEulerAngles = new Vector3(0, 0, -clawTipSlider.value);
		clawTop_tip.transform.localEulerAngles = new Vector3(0, 0, clawTipSlider.value);
	}
}

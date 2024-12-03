using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
	string Name;
	private float dailyFoodConsumption = 0;
	private int activityLevel = 0;

	public override float CalculateFoodRequirement()
	{
		throw new System.NotImplementedException();
	}

	public override void MakeSound()
	{
		Debug.Log("Dog say Jib Jib");
	}

	public override void DisplayName()
	{
		Debug.Log("Dog Name LOOMAK");
	}
}

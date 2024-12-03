using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Dog : Animal
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
		Debug.Log("Dog say Hrog Hrog");
	}

	public override void DisplayName()
	{
		Debug.Log("Dog Name KOMMAK");
	}
}

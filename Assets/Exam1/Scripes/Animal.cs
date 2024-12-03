using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

	public void Init(string name)
	{
		name = animalName;
	}

	public abstract float CalculateFoodRequirement();

    public abstract void MakeSound();

    public abstract void DisplayName();

	private void Start()
	{
		Debug.Log($"{name}");
	}
}

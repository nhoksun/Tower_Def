﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	void Awake(){

		if (instance != null) 
		{
			Debug.Log ("More than one BuildManager in scene! ");
		}
		instance = this;
	}

	public GameObject standardTurretPrefab;

	void Start()
	{
		turretToBuild = standardTurretPrefab;

	}

	private GameObject turretToBuild;

	public GameObject GetTurretToBuild()
	{
		return turretToBuild;
	}

}

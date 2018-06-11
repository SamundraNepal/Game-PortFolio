using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBulePrint standardTurret;
	public TurretBulePrint missileLauncher;
	public TurretBulePrint LaserBemar;



	BuildManager buildManager;

	void Start ()
	{


		buildManager = BuildManager.instance;

	}

	public void SelectStandredTurret ()
	{
	
		Debug.Log (" Another Standred Turret Selected");
		buildManager.SelectTurretToBuild (standardTurret);


	}

	public void SelectMissileLauncher ()
	{

		Debug.Log (" Selected Missile Launcher");
		buildManager.SelectTurretToBuild (missileLauncher);



	}

	public void SelectLaserBemar ()
	{

		Debug.Log (" Selected Laser bemar");
		buildManager.SelectTurretToBuild (LaserBemar);

	}





}



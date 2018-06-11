using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	void Awake ()
	{
		if (instance != null) {

			Debug.LogError ("More than one buildmanager in the scene");
			return;
		}

		instance = this;
	}
	public GameObject BuiltEffect;


	private TurretBulePrint turretToBuild;

	private Node selectedNode;

	public NodeUI nodeUI;

	public bool CanBuild { get {return turretToBuild != null;}}

	public bool HasMoney { get {return PlayerStats.Money >= turretToBuild.Cost;} }


	public void BuildTurretOn (Node Node)

	{


		if (PlayerStats.Money < turretToBuild.Cost) 
		{

			Debug.Log ("Not enough Money");
	

			return;
		}
		PlayerStats.Money -= turretToBuild.Cost;

		GameObject turret = (GameObject)Instantiate(turretToBuild.Prefab, Node.GetBuildPosition(), Quaternion.identity);



		Node.turret = turret;



		GameObject effect = (GameObject) Instantiate (BuiltEffect, Node.GetBuildPosition (), Quaternion.identity);
		Destroy (effect ,  5f);

		Debug.Log("Turret Build! Money left : " +PlayerStats.Money);

	}


	public void SelectNode(Node node)
	{
		if (selectedNode == node) {
		
			DeselectNode ();
			return;
		
		}
			
		selectedNode = node;
		turretToBuild = null;
		nodeUI.SetTarget (node);

	}


	public void DeselectNode ()
	{


		selectedNode = null;
		nodeUI.Hide ();
	}


	public void SelectTurretToBuild (TurretBulePrint turret) {

		turretToBuild = turret;
	   
		DeselectNode ();
	}



}


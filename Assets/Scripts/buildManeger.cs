using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class buildManeger : MonoBehaviour
{
    public static buildManeger instance;

    private void Awake()
    {
        if (instance != null) 
        {
            Debug.Log("More Than one buildmanager in scene");
        }
        instance = this;
    }
    public GameObject standartTurretPrefab;
    public GameObject anotherTurretPrefab;
    public GameObject otherTurretPrefab;
    public GameObject otherTurret;

    private turretBluprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return playerstats.Money >= turretToBuild.cost; } }
    public void SelectTurretToBuild(turretBluprint turret) 
    {
        turretToBuild = turret;
    }
    public void BuildTurretOn(howersystem howersystem)
    {
        if (playerstats.Money < turretToBuild.cost)
        {
            Debug.Log("Para yoh");
            return;
        }
        playerstats.Money -= turretToBuild.cost;

        GameObject turret= (GameObject)Instantiate(turretToBuild.prefab,howersystem.GetBuildPosition(),Quaternion.identity);
        howersystem.turret=turret;

        
    }
}

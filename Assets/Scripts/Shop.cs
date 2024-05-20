using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    buildManeger buildManeger;
    public turretBluprint standartTurret;
    public turretBluprint anotherTurret;
    public turretBluprint otherTurret;
    public turretBluprint otherAnotherTurret;
    void Start()
    {
        buildManeger = buildManeger.instance;
    }
    public void PurchaseStandartTurret()
    {
        Debug.Log("Standart Taret Alindi");
        buildManeger.SelectTurretToBuild(standartTurret);
    }
    public void PurchaseAnotherTurret()
    {
        Debug.Log("Farkli bir taret alindi");
        buildManeger.SelectTurretToBuild(anotherTurret);
    }
    public void PurchaseOtherTurretPrefab()
    {
        Debug.Log("Farkli bir taret alindi");
        buildManeger.SelectTurretToBuild(otherTurret);
    }
    public void PurchaseOtherTurret()
    {
        Debug.Log("Farkli bir taret alindi");
        buildManeger.SelectTurretToBuild(otherAnotherTurret);
    }

}

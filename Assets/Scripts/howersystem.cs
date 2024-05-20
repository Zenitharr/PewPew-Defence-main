using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class howersystem : MonoBehaviour
{
    public Color HoverColor;
    public Vector3 positionOffset;

    public Color NotEnoughMoneyColor;

    public GameObject turret;
    private Color startColor;

    private Renderer rend;
    buildManeger buildManeger;
     void Start()
    {
      rend=GetComponent<Renderer>();
        startColor=rend.material.color;
        buildManeger = buildManeger.instance;
    }
    public Vector3 GetBuildPosition()
    {
        return transform.position+positionOffset;
    }
     void OnMouseDown()
    {
        if (!buildManeger.CanBuild) 
            return;

      

        if (turret!=null) 
        {
            Debug.Log("Oraya insa edilemez");
            return;
        }
        buildManeger.BuildTurretOn(this);
    } 
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (!buildManeger.CanBuild)
            return;

        if(buildManeger.HasMoney)
        {
            rend.material.color = HoverColor;
        }
        else 
        {
            rend.material.color = NotEnoughMoneyColor;
        }

    }
    void OnMouseExit()
    {
        rend.material.color= startColor;
    }
}

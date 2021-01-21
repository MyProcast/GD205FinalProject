using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;

    public Vector3 offset;

    private GameObject turret;

    private Renderer rend;

    BuildManager buildManager;

    //Referencing the material of the gameobject
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    void OnMouseDown()
    {
        //if the build manager has no selected turret then do nothing, this is to prevent a error from returning along with 
        if(buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if (turret != null)
        {

            return;
        }

        //just creates a new turret on top of the node
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);

    }

    //changes the color of the node when the mouse enters the node on screen and reverts it when it leaves the node
    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}

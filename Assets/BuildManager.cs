using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private GameObject turretToBuild;

    //Shop script uses these two variables but its acutal game object assinment is stored in the Game Master
    public GameObject standardTurretPrefab;
    public GameObject heavyTurretPrefab;

    //References itself so other scripts can use this all of this and vise versa
    private void Awake()
    {
        instance = this;
    }


    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}

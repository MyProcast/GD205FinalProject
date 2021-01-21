using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    //These custem functions are called when the player presses its assined UI element (This is found under Canvas > Shop > Normal or heavy shop item)
    public void PurchaseStandardTurret()
    {
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseHeavyTurret()
    {
        buildManager.SetTurretToBuild(buildManager.heavyTurretPrefab);
    }
}

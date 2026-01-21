using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Gun gun;
    private bool isHoldingShoot;

    void OnShoot()
    {

        isHoldingShoot = true;
    }

    void OnShootRelease()
    {
        isHoldingShoot = false;
    }

    void OnReload()
    {
        if(gun != null)
            gun.TryReload();
    }

    void Update()
    {
        if (isHoldingShoot && gun != null)
            gun.Shoot();
    }
}

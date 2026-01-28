using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public Gun gun;
    private bool isHoldingShoot;
    public Transform gunHolder;
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

using UnityEngine;

public abstract class AbstractWeapon : MonoBehaviour
{
    [SerializeField] protected Transform barrel;
    [SerializeField] protected AbstractProjectile projectile;

    public abstract void WeaponShoot();

    protected void CreateProjectile(Transform barrel, AbstractProjectile projectile)
    {
        Instantiate(projectile, barrel.position, barrel.rotation);
    }
}

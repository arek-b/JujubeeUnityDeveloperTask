using UnityEngine;
using Weapons;

namespace Player
{
    public class PlayerWeapon : MonoBehaviour
    {
        [SerializeField] private Weapon defaultWeapon;
        [SerializeField] private Transform weaponRoot;

        private WeaponSwitching weaponSwitching;

        private void Start()
        {
            weaponSwitching ??= new WeaponSwitching(weaponRoot);
        }

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }

        private void UseWeapon()
        {

        }
    }
}
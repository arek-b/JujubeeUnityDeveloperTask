using UnityEngine;
using Weapons;

namespace Player
{
    public class PlayerWeapon : MonoBehaviour
    {
        [SerializeField] private Transform weaponRoot;
        [SerializeField] private Weapon[] availableWeapons;

        private WeaponSwitching weaponSwitching;

        private void Start()
        {
            weaponSwitching ??= new WeaponSwitching(weaponRoot);
            if (availableWeapons.Length > 0)
            {
                weaponSwitching.SwitchToWeapon(availableWeapons[0]);
            }
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
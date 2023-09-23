using System.Collections.Generic;
using UnityEngine;
using Weapons;

namespace Player
{
    public class PooledWeaponSwitching
    {
        private Weapon currentWeapon;
        private readonly Transform modelRoot;
        private readonly Dictionary<Weapon, GameObject> pool = new();

        public Weapon CurrentWeapon => currentWeapon;

        public PooledWeaponSwitching(Transform weaponModelRoot)
        {
            modelRoot = weaponModelRoot;
        }

        public void SwitchToWeapon(Weapon weaponData)
        {
            UnequipCurrentWeapon();
            EquipWeapon(weaponData);
        }

        private void UnequipCurrentWeapon()
        {
            if (currentWeapon == null)
            {
                return;
            }

            if (pool.TryGetValue(currentWeapon, out GameObject modelInstance))
            {
                modelInstance.SetActive(false);
            }

            currentWeapon = null;
        }

        private void EquipWeapon(Weapon weaponData)
        {
            currentWeapon = weaponData;
            if (pool.TryGetValue(currentWeapon, out GameObject modelInstance))
            {
                modelInstance.SetActive(true);
                return;
            }

            pool[currentWeapon] = currentWeapon.Instantiate(modelRoot);
        }
    }
}
using System.Collections.Generic;
using UnityEngine;
using Weapons;

namespace Player
{
    public class WeaponSwitching
    {
        private Weapon currentWeaponData;
        private GameObject currentWeaponModelInstance;
        private readonly Transform weaponModelRoot;
        private readonly Dictionary<Weapon, GameObject> weaponModelPool = new();

        public Weapon CurrentWeapon => currentWeaponData;

        public WeaponSwitching(Transform weaponModelRoot)
        {
            this.weaponModelRoot = weaponModelRoot;
        }

        public void SwitchToWeapon(Weapon weaponData)
        {
            UnequipCurrentWeapon();
            EquipWeapon(weaponData);
        }

        private void UnequipCurrentWeapon()
        {
            if (currentWeaponData == null)
            {
                if (currentWeaponModelInstance != null)
                {
                    Object.Destroy(currentWeaponModelInstance);
                }

                return;
            }

            weaponModelPool[currentWeaponData] = currentWeaponModelInstance;
            currentWeaponModelInstance.SetActive(false);
            currentWeaponModelInstance = null;
            currentWeaponData = null;
        }

        private void EquipWeapon(Weapon weaponData)
        {
            currentWeaponData = weaponData;
            if (weaponModelPool.TryGetValue(weaponData, out GameObject weaponModel))
            {
                weaponModel.SetActive(true);
                currentWeaponModelInstance = weaponModel;
                return;
            }

            currentWeaponModelInstance = Object.Instantiate(weaponData.Model, weaponModelRoot);
        }
    }
}
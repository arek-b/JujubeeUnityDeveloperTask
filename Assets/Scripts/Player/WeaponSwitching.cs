using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;

namespace Player
{
    public class WeaponSwitching
    {
        private GameObject currentWeaponModel;
        private WeaponType currentWeaponData;

        private Dictionary<WeaponType, GameObject> weaponModelPool = new Dictionary<WeaponType, GameObject>();

        public void SwitchToWeapon(WeaponType weaponData)
        {
            UnequipCurrentWeapon();
        }

        private void UnequipCurrentWeapon()
        {
            if (currentWeaponData == null)
            {
                if (currentWeaponModel != null)
                {
                    Object.Destroy(currentWeaponModel);
                }

                return;
            }

            weaponModelPool.Add(currentWeaponData, currentWeaponModel);
            currentWeaponModel.SetActive(false);
            currentWeaponModel = null;
            currentWeaponData = null;
        }

        private void EquipWeapon(WeaponType weaponData)
        {
            if (weaponModelPool.TryGetValue(weaponData, out GameObject weaponModel))
            {
                weaponModel.SetActive(true);
                return;
            }

            //todo handle new model instantiation
        }
    }
}
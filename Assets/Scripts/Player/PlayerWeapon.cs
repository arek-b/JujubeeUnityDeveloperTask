using System.Collections;
using UnityEngine;
using Weapons;

namespace Player
{
    public class PlayerWeapon : MonoBehaviour
    {
        [SerializeField] private WeaponType defaultWeapon;

        private WeaponSwitching weaponSwitching = new WeaponSwitching();

        private void Start()
        {
            
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
using Input;
using UnityEngine;
using UnityEngine.InputSystem;
using Weapons;

namespace Player
{
    public class PlayerWeapon : MonoBehaviour
    {
        [SerializeField] private Transform weaponRoot;
        [SerializeField] private Weapon[] availableWeapons;
        private int currentWeaponIndex = 0;
        private PooledWeaponSwitching weaponSwitching;
        private Controls controls;

        private void Awake()
        {
            controls = new Controls();
            weaponSwitching = new PooledWeaponSwitching(weaponRoot);
            if (availableWeapons.Length > 0)
            {
                weaponSwitching.SwitchToWeapon(availableWeapons[0]);
            }
        }

        private void OnEnable()
        {
            controls.WeaponControls.Enable();
            controls.WeaponControls.UseWeapon.performed += UseWeapon;
            controls.WeaponControls.NextWeapon.performed += SwitchToNextWeapon;
        }

        private void OnDisable()
        {
            controls.WeaponControls.Disable();
            controls.WeaponControls.UseWeapon.performed -= UseWeapon;
            controls.WeaponControls.NextWeapon.performed -= SwitchToNextWeapon;
        }

        private void UseWeapon(InputAction.CallbackContext context)
        {
            if (weaponSwitching?.CurrentWeapon == null)
            {
                return;
            }

            weaponSwitching.CurrentWeapon.Use();
        }

        private void SwitchToNextWeapon(InputAction.CallbackContext context)
        {
            if (availableWeapons.Length <= 0)
            {
                Debug.LogWarning("Cannot switch weapon because there are no available weapons");
                return;
            }

            currentWeaponIndex = (currentWeaponIndex + 1) % availableWeapons.Length;
            weaponSwitching.SwitchToWeapon(availableWeapons[currentWeaponIndex]);
        }
    }
}
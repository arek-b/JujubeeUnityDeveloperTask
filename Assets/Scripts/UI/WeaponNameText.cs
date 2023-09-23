using Player;
using Weapons;
using UnityEngine;
using TMPro;

namespace UI
{
    public class WeaponNameText : MonoBehaviour
    {
        [SerializeField] private TMP_Text textMesh;
        private Weapon currentWeapon;

        private void Awake()
        {
            PooledWeaponSwitching.OnEquippedWeaponChanged += PooledWeaponSwitching_OnEquippedWeaponChanged;
        }

        private void OnEnable() => UpdateText();

        private void OnDisable() => textMesh.text = string.Empty;

        private void PooledWeaponSwitching_OnEquippedWeaponChanged(Weapon weapon)
        {
            currentWeapon = weapon;
            if (enabled)
            {
                UpdateText();
            }
        }

        private void UpdateText()
        {
            textMesh.text = currentWeapon == null ? string.Empty : currentWeapon.Name;
        }
    }
}
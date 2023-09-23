using Player;
using Weapons;
using UnityEngine;
using TMPro;

namespace UI
{
    public class WeaponNameText : MonoBehaviour
    {
        [SerializeField] private TMP_Text textMesh;
        private string currentWeaponName;

        private void Awake()
        {
            PooledWeaponSwitching.OnEquippedWeaponChanged += PooledWeaponSwitching_OnEquippedWeaponChanged;
        }

        private void Start() => UpdateText();

        private void OnEnable() => UpdateText();

        private void OnDisable() => textMesh.text = string.Empty;

        private void PooledWeaponSwitching_OnEquippedWeaponChanged(Weapon weapon)
        {
            currentWeaponName = weapon == null ? string.Empty : weapon.Name;
            UpdateText();
        }

        private void UpdateText()
        {
            if (enabled == false)
            {
                return;
            }

            textMesh.text = currentWeaponName;
        }
    }
}
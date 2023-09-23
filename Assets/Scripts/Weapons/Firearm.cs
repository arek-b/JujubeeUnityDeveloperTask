using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "Firearm", menuName = "ScriptableObjects/Weapons/Firearm")]
    public class Firearm : Weapon
    {
        [SerializeField] private int ammoPerMagazine;
        [SerializeField] private int maxTotalAmmo;

        public override void Use()
        {
            Debug.Log($"Using a firearm: {weaponName} ({damage} DMG, ammoPerMagazine: {ammoPerMagazine}, "
                      + $"maxTotalAmmo: {maxTotalAmmo})");
        }
    }
}
﻿using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "MeleeWeapon", menuName = "ScriptableObjects/Weapons/MeleeWeapon")]
    public class Melee : Weapon
    {
        [SerializeField] private bool twoHanded;

        public override void Use()
        {
            Debug.Log($"Using a melee weapon: {weaponName} ({damage} DMG, twoHanded: {twoHanded})");
        }
    }
}
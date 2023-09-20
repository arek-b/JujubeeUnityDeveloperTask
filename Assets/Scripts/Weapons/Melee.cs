using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "MeleeWeapon", menuName = "ScriptableObjects/Weapons/MeleeWeapon")]
    public class Melee : WeaponType
    {
        [SerializeField] private bool twoHanded;

        public override void Use()
        {
            Debug.Log("Using a melee weapon");
        }
    }
}
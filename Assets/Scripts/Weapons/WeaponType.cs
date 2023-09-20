using UnityEngine;

namespace Weapons
{
    public abstract class WeaponType : ScriptableObject
    {
        [SerializeField] private string weaponName;
        [SerializeField] private float damage;

        public abstract void Use();
    }
}
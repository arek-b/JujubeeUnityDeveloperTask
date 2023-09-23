using UnityEngine;

namespace Weapons
{
    public abstract class Weapon : ScriptableObject
    {
        [SerializeField] private GameObject model;
        [SerializeField] protected string weaponName;
        [SerializeField] protected float damage;

        public GameObject Model => model;

        public abstract void Use();
    }
}
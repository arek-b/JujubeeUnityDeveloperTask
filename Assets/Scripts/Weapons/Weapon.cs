using UnityEngine;

namespace Weapons
{
    public abstract class Weapon : ScriptableObject
    {
        [SerializeField] private GameObject model;
        [SerializeField] private string weaponName;
        [SerializeField] private float damage;

        public GameObject Model => model;

        public abstract void Use();
    }
}
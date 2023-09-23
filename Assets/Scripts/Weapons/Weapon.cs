using UnityEngine;

namespace Weapons
{
    public abstract class Weapon : ScriptableObject
    {
        [SerializeField] private GameObject model;
        [SerializeField] private float modelScaleMultiplier = 1f;
        [SerializeField] protected string weaponName;
        [SerializeField] protected float damage;

        public GameObject Instantiate(Transform parent)
        {
            GameObject instance = Instantiate(model, parent);
            instance.transform.localScale *= modelScaleMultiplier;
            return instance;
        }

        public abstract void Use();
    }
}
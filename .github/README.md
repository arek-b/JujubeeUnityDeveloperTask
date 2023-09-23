## Usage instructions

### Finding existing weapons
You can locate pre-existing weapon ScriptableObjects by accessing the `Assets/Data/Weapons` directory.

### Creating new weapons
1. Right-click within any directory in the Project pane.
2. Navigate to `Create > ScriptableObjects > Weapons`.
3. Select the desired weapon type to add to the project.

### Adding new weapon types
To add a new weapon type to the project, you'll need to:
- Extend the `Weapons.Weapon` class.
- Implement the abstract `Use()` method.
- Add a `CreateAssetMenu` attribute to the derived class, enabling the creation of new weapons of this specific type. For example:<br>`[CreateAssetMenu(fileName = "Ranged", menuName = "ScriptableObjects/Weapons/Ranged")]`
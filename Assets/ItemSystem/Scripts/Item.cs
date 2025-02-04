using UnityEngine;

public class Item : MonoBehaviour {
	public GameObject itemPrefab;
	public Sprite icon;

	public string itemName;
	[TextArea(4, 16)]
	public string description;

	public float weight = 0;
	public int quantity = 1;

	// for bundles of items, such as arrows or coins
	public int maxStackableQuantity = 1;

	// if false, item will be used when picked up
	public bool isStorable = false;

	// if true, item will be destroyed (or quantity reduced) when used
	public bool isConsumable = true;

	void Start() { 
	}

	void Update() {
	}

	public void Interact() {
		Debug.Log("Picked up " + transform.name);

		if (isStorable) {
			Store();
		}
		else {
			Use();
		}
	}

	void Store() {
		Debug.Log("Storing " + transform.name);

		// Todo

		Destroy(gameObject);
	}

	void Use() {
		if (isConsumable) {
			quantity--;
			if (quantity <= 0) {
				Destroy(gameObject);
			}
		}
	}
}

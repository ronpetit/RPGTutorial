﻿using UnityEngine;

public class Interactable : MonoBehaviour {
	public float radius = 3f;
	public Transform interactionTransform;
	bool isFocus = false;
	bool hasInteracted = false;
	Transform player;

	public virtual void Interact()
	{
		Debug.Log("Interaction");
	}

	void Update()
	{
		if (isFocus && !hasInteracted)
		{
			float distance = Vector3.Distance(player.position, interactionTransform.position);
			if (distance <= radius) 
			{
				Interact();
				hasInteracted = true;
			}
		}
	}

	public void Onfocused(Transform playerTransform)
	{
		isFocus = true;
		player = playerTransform;
		hasInteracted = false;
	}

	public void OnDefocused()
	{
		isFocus = false;
		player = null;
		hasInteracted = false;
	}

	void OnDrawGizmosSelected() {
		if (interactionTransform == null) {
			interactionTransform = transform;
		}
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(interactionTransform.position, radius);
	}
}

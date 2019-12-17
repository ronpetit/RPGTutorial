﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shield, Feet }
public enum EquipmentMeshRegion { Legs, Torso } //Blend shapes

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item {

	public EquipmentSlot equipSlot;
	public SkinnedMeshRenderer mesh;
	public EquipmentMeshRegion[] coveredMeshRegions;
	public int armorModifier;
	public int damageModifier;

	public override void Use() {
		base.Use();
		EquipmentManager.instance.Equip(this);
		RemoveFromInventory();
	}
}

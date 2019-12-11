﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shield, Feet }

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item {

	public EquipmentSlot equipSlot;
	public int armorModifier;
	public int damageModifier;

	public override void Use() {
		base.Use();
		
	}
}

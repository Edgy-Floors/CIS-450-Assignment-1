/*
 * EJ Flores
 * Weapon.cs
 * Assignment 1
 * This abstract class gets inherited by the sword and spear classes.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon 
{
    public float damage = 10.2F;
    public void attack(float damage)
    {
        Debug.Log("This is an attack from the abstract class Weapon.");
    }
}

/*
 * EJ Flores
 * Spear.cs
 * Assignment 1
 * This file implements the slash and throwWeapon methods from the two interfaces.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon, IMelee, IRanged
{
    public float bleedPerSecond = 4.2F;
    public float distance = 25.4F;
    public void slash(float bleedPerSecond)
    {
        Debug.Log("This method applies a bleed to an enemy from the spear that does " + bleedPerSecond + " damage per second.");
    }

    public void throwWeapon(float distance)
    {
        Debug.Log("This method throws the spear at a distance of " + distance + ".");
    }

    public override void attack(float damage)
    {
        Debug.Log("This method overrides the Weapon class and calls the Spear's attack function.");
    }
}

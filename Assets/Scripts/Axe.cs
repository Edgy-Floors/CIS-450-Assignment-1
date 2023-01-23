/*
 * EJ Flores
 * Axe.cs
 * Assignment 1
 * This file implements the slash and throwWeapon methods from the two interfaces.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Weapon, IMelee, IRanged
{
    public float bleedPerSecond = 5.2F;
    public float distance = 24.7F;
    public void slash(float bleedPerSecond)
    {
        Debug.Log("This method applies a bleed to an enemy from the axe that does " + bleedPerSecond + " damage per second.");
    }

    public void throwWeapon(float distance)
    {
        Debug.Log("This method throws the axe at a distance of " + distance + ".");
    }
}

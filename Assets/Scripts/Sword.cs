/*
 * EJ Flores
 * Sword.cs
 * Assignment 1
 * This file implements the slash, unSheath, and sheath methods from the two interfaces.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon, IMelee, ISheathable
{
    public float bleedPerSecond = 6.9F;
    public float sheathTime = 1.7F;

    public void slash(float bleedPerSecond)
    {
        Debug.Log("This method applies a bleed to an enemy from the sword that does " + bleedPerSecond + " damage per second.");
    }

    public void unSheath(float sheathTime)
    {
        Debug.Log("This method unSheathes the sword weapon, playing an animation for " + sheathTime + " seconds.");
    }

    public void sheath(float sheathTime)
    {
        Debug.Log("This method sheathes the sword weapon, playing an animation for " + sheathTime + " seconds.");
    }

    public override void attack(float damage)
    {
        Debug.Log("This method overrides the Weapon class and calls the Sword's attack function.");
    }
}

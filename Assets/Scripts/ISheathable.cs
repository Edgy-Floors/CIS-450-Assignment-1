/*
 * EJ Flores
 * ISheathable.cs
 * Assignment 1
 * This is the interface for sheathable weapons.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISheathable
{
    void sheath(float sheathTime);
    void unSheath(float sheathTime);
}

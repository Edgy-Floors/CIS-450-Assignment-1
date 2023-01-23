/*
 * EJ Flores
 * ConsoleOutput.cs
 * Assignment 1
 * This code runs tests on both of the concrete classes as notated in the Assignment description.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Spear s = new Spear();
        Sword sw = new Sword();
        Spear s1 = new Spear();
        Sword sw1 = new Sword();
        Axe a = new Axe();
        Axe a1 = new Axe();

        s.slash(s.bleedPerSecond);
        sw.slash(sw.bleedPerSecond);
        s.throwWeapon(s.distance);
        sw.sheath(sw.sheathTime);
        sw.unSheath(sw.sheathTime);
        a.slash(a.bleedPerSecond);
        a.throwWeapon(a.distance);
    }

    Spear s1 = new Spear();
    Spear s2 = new Spear();
    Sword sw1 = new Sword();
    Sword sw2 = new Sword();
    Axe a1 = new Axe();
    Axe a2 = new Axe();
    private List<Weapon> l = new List<Weapon>();
    private List<IMelee> l1 = new List<IMelee>();


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            l.Add(s1);
            l.Add(s2);
            l.Add(sw1);
            l.Add(sw2);
            l.Add(a1);
            l.Add(a2);
            
            foreach(Weapon w in l)
            {
                w.attack(w.damage);
            }

            l.Clear();
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            l1.Add(s1);
            l1.Add(s2);
            l1.Add(sw1);
            l1.Add(sw2);
            l1.Add(a1);
            l1.Add(a2);


            foreach(IMelee im in l1)
            {
                
            }

            l1.Clear();
        }
    }
}

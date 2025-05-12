using System;
using UnityEngine;

[System.Serializable]
public class NinjaFrogStats
{
    public int maxLives = 3;          
    public float speed = 5f;        
    public float jumpForce = 10f;    
    public int attackPower = 1;     
    public int attackRange = 1;
    public int currentHP;

    public bool CanAttack(int attackPower, int attackRange)
    {
        if (attackPower > 0 && attackRange > 0)
        {
            return true;
        }
        return false;
    }

    /*
     * EditMode Tests: Cualquier clase que incorpore métodos que devuelvan algún dato != void 
    int darPuñetazo(int fuerza);    //Devuelve la cantidad de vida que perdemos al dar un puñetazo con intensidad “fuerza” 
    boolean peleaCon(Personaje p2); //Devuelve true si en la pelea con ”p2”; resulto ganador. Falso en otro caso. Ganará quien tenga más fuerza
    float getFuerza();              //Devuelve la fuerza de un personaje. No puede haber fuerzas negativas.
    boolean estaVivo();             //Devuelve true si estas vivo. False en otro caso. El personaje estará vivo si tiene fuerza (fuerza &gt; 0)
    bool PuedeHacerAtaqueEspecial() // Devuelve true si tiene al menos 50 puntos de energía.
    */

    public int getFuerza()
    {
        return attackPower;
    }

    public bool estaVivo(int currentHP)
    {
        if (currentHP > 0)
        {
            return true;
        } else
        {
            return false;
        }
    }
}

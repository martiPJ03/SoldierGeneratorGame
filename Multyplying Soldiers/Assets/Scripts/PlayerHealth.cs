using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthSlider;  // Referencia al slider de vida
    public TextMeshProUGUI textLose;
    public int maxHealth = 10;  // M�xima cantidad de vida
    private int currentHealth;   // Vida actual de la unidad
    void Start()
    {
        textLose.enabled = false;
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;  // Establecer el valor m�ximo del slider
        healthSlider.value = currentHealth; // Establecer el valor inicial del slider
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDmgBase(int dmg)
    {
        currentHealth -= dmg;  // Restar la cantidad de da�o de la vida actual
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Asegurarse de que la vida no baje de 0
        healthSlider.value = currentHealth;  // Actualizar el valor del slider
        if (currentHealth == 0)
        {
            textLose.enabled = true;
            Time.timeScale = 0f;
        }
    }
}

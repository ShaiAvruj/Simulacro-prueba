using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos
y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. 
Luego indicar cuánto dinero sobra o falta.*/
public class EJ02 : MonoBehaviour
{
    public int producto1;
    public int producto2;
    public int producto3;
    public int montoDinero;
    // Start is called before the first frame update
    void Start()
    {
        if ((producto1 + producto2 + producto3) > montoDinero) {
            Debug.Log("El total supera la cantidad de dinero por $" + ((producto1 + producto2 + producto3) - montoDinero) + ".");
        }
        else
        {
            Debug.Log("El total no supera la cantidad de dinero por $" + (montoDinero - (producto1 + producto2 + producto3)) + ".");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.EstructurasDeControl
{
    internal class OperadoresYExpresiones
    {
        int x = 10;

        // ((x != 10) && (x > 5)) || ((x > 20) && (x < 25))

        // Dos tipos de declaración
        /*
         * Literal
         * int i = 5;
         * 
         * Nombre
         * int numMax = 5;
         * 
         * Expersión Invocación
         * ();
        */

        // Operadores
        /*
         
        // Operadores primarios

        x.y acceso a miembros de clase
        x?.y acceso a miembros de clae con condicional

        M(x) Invocación de Método (con parámetros opcional)
        a[x] Posición de Array
        a?[x] Posición de Array con condicional
        x++ Post-incremento
        x-- Post-decremento
        new T(...) Creación de Objetos
        new T(...){...} Creación de Objetos con inicializador

        // Operadores Unarios

        +x Indica número positivo
        -x Indica número negativo
        !x Negación lógica
        ++x Pre-incremento
        --x Pre-decremento
        (T)x Conversión de tipos explícita

        // Operadores de multiplicación
        * multiplicación
        / División
        % Módulo o resto

        // Operadores de adición

        x + y Sumas, concatenación de strings
        x - y Sustracción

        // Operadores de relación

        x < y menor que
        x > y mayor que
        x <= y menor o igual que
        x >= y mayor o igual que

        // Operadores de igualdad

        x == y Igual
        x != y No Igual

        // Operadores Lógicos y Condicionales

        x && y Lógico AND       if (x == 10 && y = 20) 
                                Si se cumplen todos los casos

        x || y Condicional OR   (x == 10 || y == 20)
                                Si se cumple uno de los casos

        // Asignación

        x op = y
        +=, -=, *=, /=, %=, &=, |=, != (Asignaciones compuestas)

        // Asociación

        int a, b ,c;
        c = 1;
        a = b = c;
        a = (b = c);
        a = b + c

        // Agregando paréntesis

        a = (b + c) * d

        a = b - (c + d)

        a = (b + c) * (d - e)

        */
    }
}

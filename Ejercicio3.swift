// Gabriela Marisol Dominguez Hernandez
// 25-0925-2017

/* ENUNCIADO:
 Dada la funcion M_PI en Swift que permite obtener el valor de Pi(Π), 
 a utilizar para calcular el area de un circulo con radio 5; 
 escribir el codigo Swift para la realizacion del caculo, 
 la formula es: A=Πr2 (donde: A es area, r2 radio al cuadrado y Π es pi ).
 */

import Foundation

let pi = M_PI
var r:Int = 5
var A:Double = 0.0

A = pi * Double ( r * r )

//Reducimos decimales
A = round(10000 * A) / 10000 
print("El Area es: \(A)")
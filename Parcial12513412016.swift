//: Playground - noun: a place where people can play
//Nombre: 0Katherine Guadalupe Hernandez de la Cruz
//Carnet: 25-2467-2017

import UIKit

//Elabore un programa que calcule la suma de nos numeros cualquiera, donde los valores deben ser de tipo float.
var valor1:Float = 26.345
var valor2:Float = 13.455
var resula:Float = 0.00 //A variable se asigna el resultado de operacion.

resula=valor1 + valor2

print("La suma de \(valor1) mas \(valor2) es : \(resula)")


//Elabore un programa que multiplique dosnumeros cualquiera, donde los valores sean float y el resultado sea int.

import Foundation

var num1:Float = 16.345
var num2:Float = 20.455
var resul:Int = Int(num1 * num2)

print("Resultado entero de la suma: \(resul)")


// Dada la funcion Double.pi en Swift que permite obtener el valor de Pi(Π), a utilizar para calcular el area de un circulo con radio 5; escribir el codigo Swift para la realizacion del caculo, la formula es: A=Πr2 (donde: A es area, r2 radio al cuadrado y Π es pi )

var area: Double = 0.0
var radio: Double = 5.0
var pi = Double.pi
area = pi * (radio*radio)

print("El area es : \(area)")
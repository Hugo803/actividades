//
//  main.swift
//  Parcial2534672017
//
//  Created by Development on 9/25/21.
//  Copyright © 2021 Development. All rights reserved.
//
//Garcia Ayala Cristian Vladimir
//25-3467-2017

import Foundation

var salaB:Double = 425.00, bono:Double = 0.0, unidadven: Int = 0, comision:Double = 0.0;
var res = "", nempleado = "", input = "";

var lempleados: Array <String> = [];

var ovendedor = true

func getInputText() -> String {
    var input=""
    input=NSString(data: FileHandle.standardInput.availableData, encoding:String.Encoding.utf8.rawValue)! as String
    input = input.replacingOccurrences(of: "\n", with: "", options: NSString.CompareOptions.literal, range: nil)
    return input
}


while ovendedor {
    print("Ingrese Nombre del empleado: ")
    nempleado = getInputText();
    
    print("Ingrese Unidades vendidas: ")
    res = getInputText();
    unidadven = Int(res) ?? 0;
    
    
    if(unidadven <= 200) {
        bono = 0
        comision =  Double(unidadven) * 0.75;
        
    } else if (unidadven > 200 && unidadven <= 750) {
        bono = 100.00
        comision =  Double(unidadven) * 1.25;
        
    } else if (unidadven > 750 && unidadven <= 1025) {
        let calculo = unidadven / 100;
        bono = Double(calculo) * 50;
        comision =  Double(unidadven) * 1.45;
        
    } else {
        let calculo = unidadven / 100;
        bono = Double(calculo) * 75;
        comision =  Double(unidadven) * 1.65;
    }
    
    
    lempleados.append("Nombre: \(nempleado) \n Unidades Vendidas: \(unidadven) \n Comision: \(comision) \n Bonificacion: \(bono) \n Salario Neto: \(salaB +  comision + bono) ");
    
    print ("Ingresar otro Vendedor? S o N")
    input = getInputText();
    
    if input == "N" || input == "n" {
        // Imprimir el lista de vendedores
        
        for empleado in lempleados {
            print(empleado)
        }
        
        ovendedor = false
    }
    
}

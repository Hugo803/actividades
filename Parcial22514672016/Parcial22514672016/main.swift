//
//  main.swift
//  Parcial22514672016
//
//  Created by alexis on 17/3/21.
//  Copyright © 2021 development. All rights reserved.
//

import Foundation

// print("Hello, World!")

//Wilber Alexis Jorge Ramirez
//25-1467-2016
//

//Datos que se tiene que solicitar
// cantidad de vendedores N Vendedores
//Nombre del vendedor
//las Unidades vendidas
// se debe calcular la Comision
//bonificacion 
//salario neto

var val:String = ""
var n:Int = 0

// creamos la clase vendedor con sus atributos
class Vendedor {
    var comision:Float = 0.00
    var nombreVendedor:String = ""
    var bonificacion:Float = 0.00
    var unidadesVendida:Int = 0
    var salarioNeto:Float = 0.00
    var salariobase:Float = 425.00
    
}



var Vendedores = [Vendedor]()
// solicitamos y capturamos datos
print("Digite el Total de vendedores a calcular: ")
val = NSString(data: FileHandle.standardInput.availableData, encoding:String.Encoding.utf8.rawValue)! as String
val = val.replacingOccurrences(of: "\n", with: "", options: NSString.CompareOptions.literal, range: nil)
n = Int(val)!

// validamos que se cumpla mientras
for var i in 0..<n
{
    let regTrabajador = Vendedor()
    i+=1
    print("Digite el nombre del trabajador #\(i)")
    regTrabajador.nombreVendedor = NSString(data: FileHandle.standardInput.availableData, encoding:String.Encoding.utf8.rawValue)! as String
    regTrabajador.nombreVendedor = regTrabajador.nombreVendedor.replacingOccurrences(of: "\n", with: "", options: NSString.CompareOptions.literal, range: nil)
    
    print("Digite la unidades vendidas")
    var uv = NSString(data: FileHandle.standardInput.availableData, encoding:String.Encoding.utf8.rawValue)! as String
    uv = uv.replacingOccurrences(of: "\n", with: "", options: NSString.CompareOptions.literal, range: nil)
    regTrabajador.unidadesVendida = Int(uv)!
    
    if(regTrabajador.unidadesVendida >= 0 && regTrabajador.unidadesVendida <= 200){
        regTrabajador.comision = Float(regTrabajador.unidadesVendida) * 0.75
    }
        
    else if(regTrabajador.unidadesVendida >= 201 && regTrabajador.unidadesVendida <= 750){
        regTrabajador.comision = Float(regTrabajador.unidadesVendida) * 1.25
        
        //Bono de $100 si a vendido mas de 500 unidades hasta 750 unidades
        if(regTrabajador.unidadesVendida > 500 && regTrabajador.unidadesVendida <= 750){
            regTrabajador.bonificacion = 100.00
        }
    }
        //Bono de $50 por cada ciento de unidades vendidas comprendidas entre 751 y 1025
    else if(regTrabajador.unidadesVendida >= 751 && regTrabajador.unidadesVendida <= 1025){
        regTrabajador.comision = Float(regTrabajador.unidadesVendida) * 1.45
        var cien50:Float = (Float(regTrabajador.unidadesVendida) - 750) / 100
        regTrabajador.bonificacion = Float(Int(cien50) * 50)
    }
        
    else if(regTrabajador.unidadesVendida >= 1026){
        regTrabajador.comision = Float(regTrabajador.unidadesVendida) * 1.65
        if(regTrabajador.unidadesVendida > 2000){
            var cien75:Float = (Float(regTrabajador.unidadesVendida) - 2000) / 100
            regTrabajador.bonificacion = Float(Int(cien75) * 75)
        }
    }

    
    //Sumar el salario base $425 + comision + bonificacion
    regTrabajador.salarioNeto = regTrabajador.salariobase + regTrabajador.comision +  regTrabajador.bonificacion
    Vendedores.append(regTrabajador)
}

for item in Vendedores {
    
    print("")
    print("===============================================")
    //Mostrar la lista de trabajadores Nombre,Unidades vendidas, comision y salario neto
    //No menciona que se deba mostrar el salario base por lo que se omite, en todo caso solo se agrega al print ya que existe en la clase.
    print("Nombre del trabajador: \(item.nombreVendedor) \nUnidades vendidas:\(item.unidadesVendida) \nComision: \(item.comision) \nBonificacion: \(item.bonificacion) \nSalario neto: \(item.salarioNeto)")
    
}

//
//  main.swift
//  Created by Development on 3/15/21.
//  Copyright © 2021 Development. All rights reserved.
//
//Hugo Ernesto Jovel Martinez
//25-0539-2015

import Foundation

//print("Hello, World!")

//se debe Solicitar N Vendedores

var val:String = ""
var n:Int = 0

//Declaramos la variables a utilizar
class Empleado {
    var comision:Float = 0.00
    var nombre:String = ""
    var bonificacion:Float = 0.00
    var unidadesVendida:Int = 0
    var salariobase:Float = 425.00
    var salarioNeto:Float = 0.00
    
}
//Captura de informacion de vendedores a calcular salario
var VendedorLis = [Empleado]()
print("Digite la cantidad de vendedores a calcular: ")
val = NSString(data: FileHandle.standardInput.availableData, encoding:String.Encoding.utf8.rawValue)! as String
val = val.replacingOccurrences(of: "\n", with: "", options: NSString.CompareOptions.literal, range: nil)
n = Int(val)!

for var i in 0..<n
{
    let regTrabajador = Empleado()
    i+=1
    //Ingrese el nombre del trabajador
    print("Digite el nombre del trabajador #\(i)")
    regTrabajador.nombre = NSString(data: FileHandle.standardInput.availableData, encoding:String.Encoding.utf8.rawValue)! as String
    regTrabajador.nombre = regTrabajador.nombre.replacingOccurrences(of: "\n", with: "", options: NSString.CompareOptions.literal, range: nil)
    //Ingreso de las unidades vendidas
    print("Digite la unidades vendidas")
    var uv = NSString(data: FileHandle.standardInput.availableData, encoding:String.Encoding.utf8.rawValue)! as String
    uv = uv.replacingOccurrences(of: "\n", with: "", options: NSString.CompareOptions.literal, range: nil)
    regTrabajador.unidadesVendida = Int(uv)!
    
    //Rango de unidades de 0 a 200
    if(regTrabajador.unidadesVendida >= 0 && regTrabajador.unidadesVendida <= 200){
        regTrabajador.comision = Float(regTrabajador.unidadesVendida) * 0.75
    }
        //Se calcula el bono de los 100 que esta en el rango 201 a 750
    else if(regTrabajador.unidadesVendida >= 201 && regTrabajador.unidadesVendida <= 750){
        regTrabajador.comision = Float(regTrabajador.unidadesVendida) * 1.25
        
        //Bono de $100 si a vendido mas de 500 unidades hasta 750 unidades
        if(regTrabajador.unidadesVendida >= 500 && regTrabajador.unidadesVendida <= 750){
            regTrabajador.bonificacion = 100.00
        }
    }
        //Bono de $50 por cada ciento de unidades vendidas comprendidas entre 751 y 1025
    else if(regTrabajador.unidadesVendida >= 750 && regTrabajador.unidadesVendida <= 1025){
        regTrabajador.comision = Float(regTrabajador.unidadesVendida) * 1.45
        let cien50:Float = (Float(regTrabajador.unidadesVendida) - 750) / 100
        regTrabajador.bonificacion = Float(Int(cien50) * 50)
    }
        //Rango mayor  a 1026 unidades
    else if(regTrabajador.unidadesVendida >= 1026){
        regTrabajador.comision = Float(regTrabajador.unidadesVendida) * 1.65
        if(regTrabajador.unidadesVendida > 2000){
            let cien75:Float = (Float(regTrabajador.unidadesVendida) - 2000) / 100
            regTrabajador.bonificacion = Float(Int(cien75) * 75)
        }
    }
    
    //Sumar salario base $425 + comision + bonificacion
    regTrabajador.salarioNeto = regTrabajador.salariobase + regTrabajador.comision +  regTrabajador.bonificacion
    VendedorLis.append(regTrabajador)
}

for item in VendedorLis {
    print("")
    print("=============================================")
    //Mostrar la lista de trabajadores Nombre,Unidades vendidas, comision y salario neto
    //No menciona que se deba mostrar el salario base por lo que se omite, en todo caso solo se agrega al print ya que existe en la clase.
    print("Nombre del trabajador: \(item.nombre) \nUnidades vendidas:\(item.unidadesVendida) \nComision: \(item.comision) \nBonificacion: \(item.bonificacion) \nSalario neto: \(item.salarioNeto)")
}

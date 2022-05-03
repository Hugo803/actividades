//
//  ImpuestoRenta.swift
//  09042022G5
//
//  Created by Development on 4/9/22.
//  Copyright © 2022 Development. All rights reserved.
//

import Foundation

class impuestoRenta{
    var salario:Double=0.00
    var renta:Double=0.00
    
    func rentamensual(){
        if (salario >= 0.01 && salario <= 472.00){renta = 0.00}
        if (salario >= 472.01 && salario <= 895.24){renta = (((salario - 472.00)*0.1)+17.67)}
        if (salario >= 895.25 && salario <= 2038.10){renta = (((salario - 895.24)*0.20)+60.00)}
        if (salario >= 2038.11){renta = (((salario - 2038.10)*0.30)+288.57)}
    }
    
    func rentaquincenal(){
        switch salario {
        case 0.01...236.00:
            renta = 0.00
        case 236.01...447.62:
            renta = (((salario - 236.00)*0.1)+8.83)
        case 447.63...1019.05:
            renta = (((salario - 447.62)*0.20)+30.00)
        default:
            renta = (((salario - 1019.05)*0.30)+144.28)
        }
    }
    
    func rentasemanal(){
        if ( salario >= 0.01 && salario <= 118.00){renta = 0.00}
        if (salario >= 118.01 && salario <= 223.81){renta = (((salario - 118.00)*0.1)+4.42)}
        if (salario >= 223.82 && salario <= 509.52){renta = (((salario - 223.81)*0.20)+15.00)}
        if (salario >= 509.53){renta = (((salario - 509.52)*0.30)+72.14)}
        
    }
    
}

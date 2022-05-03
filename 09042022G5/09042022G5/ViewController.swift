//
//  ViewController.swift
//  09042022G5
//  katherine Guadalupe Hernandez de la Cruz
//  Marcela Beatriz Sotelo Cantarero
//  Edwin Giovanni Duran Molina
//  Irvin Adrian Hernandez Campos
//  Yensy Vanessa Aguilar Mejia
//  Hugo Ernesto Jovel Martinez
//  Created by Development on 4/9/22.
//  Copyright © 2022 Development. All rights reserved.
//

import UIKit

class ViewController: UIViewController, UIPickerViewDataSource,UIPickerViewDelegate {
    
    @IBOutlet weak var mylabel: UILabel!
    @IBOutlet weak var txtsalario: UITextField!
    @IBOutlet weak var txtNombre: UITextField!
    @IBOutlet weak var formadepago: UIPickerView!
    @IBOutlet weak var impuestorenta: UILabel!
    @IBOutlet weak var btnCalcular: UIButton!
    let opciones = ["1- Semanal","2- Quincenal","3- Mensual"]
    var seleccion:Int=0
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
        formadepago.dataSource=self
        formadepago.delegate=self
        
    }
    
    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    
    
    @IBAction func fxCalcular(_ sender: UIButton) {
        let objImpuestoRenta:impuestoRenta=impuestoRenta()
        objImpuestoRenta.salario=Double(txtsalario.text!)!
        switch seleccion {
        case 0:
            objImpuestoRenta.rentasemanal()
        case 1:
            objImpuestoRenta.rentaquincenal()
        case 2:
            objImpuestoRenta.rentamensual()
        default:
            objImpuestoRenta.renta=0.00
        }
        impuestorenta.text=String(objImpuestoRenta.renta)
    }
    
    func numberOfComponents(in pickerView: UIPickerView) -> Int {
        return 1
    }
    func pickerView(_ pickerView: UIPickerView, numberOfRowsInComponent component: Int) -> Int {
        return opciones.count
    }
    
    func pickerView(_ pickerView: UIPickerView, titleForRow row: Int, forComponent component: Int) -> String? {
        return opciones[row]
    }
    
    func pickerView(_ pickerView: UIPickerView, didSelectRow row: Int, inComponent component: Int) {
        seleccion = row
        mylabel.text=opciones[row]
    }
    
    
}


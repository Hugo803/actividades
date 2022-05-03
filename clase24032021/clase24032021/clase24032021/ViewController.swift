//
//  ViewController.swift
//  clase24032021
//
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var calculo: UISegmentedControl!
    @IBOutlet weak var resultado: UILabel!
    @IBOutlet weak var valor2: UITextField!
    @IBOutlet weak var valo1: UITextField!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }


    @IBAction func calcular(_ sender: UISegmentedControl) {
        var opcion:String=""
        var Valor1:Int=0
        var Valor2:Int=0
        var Resultado:Int=0
        Valor1=Int(valo1.text!)!
        Valor2=Int(valor2.text!)!
        opcion=calculo.titleForSegment(at: calculo.selectedSegmentIndex)!
        resultado.text=opcion
        
        switch opcion{
            case "+":
            Resultado=Valor1+Valor2
        case "-":
            Resultado=Valor1-Valor2
        case "x":
            Resultado=Valor1*Valor2
        default:
            Resultado=Valor1/Valor2
            
        }
        resultado.text = String(Resultado)
    }
    
    @IBAction func cambio(_ sender: UITextField) {
        var dato:Int=0
        dato=Int(valor2.text!)!
        if dato == 0{
            calculo.setEnabled(false, forSegmentAt: 3)
        }else{
            calculo.setEnabled(true, forSegmentAt: 3)
        }
        
    }
    
}



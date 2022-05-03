//
//  ViewController.swift
//  Parcial32562862014
//
//  Created by aureliano on 21/4/21.
//  Copyright © 2021 aureliano. All rights reserved.
//

// Aureliano Martinez
// 25-6286-2014


import UIKit

class ViewController: UIViewController {
    
    var lista:[String]=[""]

    @IBOutlet weak var txtDato: UITextField!
    
    @IBOutlet weak var btnGuardar: UIButton!
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    
    @IBAction func Guardar(_ sender: UIButton) {
        lista.append(txtDato.text!)
        txtDato.text=""
    }
    
    
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        let vc2 = segue.destination as? ViewController2
        vc2?.dato=lista
    }
    

}


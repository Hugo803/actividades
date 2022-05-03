//
//  ViewController2.swift
//  Parcial32562862014
//
//  Created by aureliano on 21/4/21.
//  Copyright © 2021 aureliano. All rights reserved.
//

// Aureliano Martinez
// 25-6286-2014

import UIKit

class ViewController2: UIViewController, UITableViewDataSource,
UITableViewDelegate {
    
    
    @IBOutlet weak var listTableView: UITableView!
    var dato:[String]=[""]
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        // Do any additional setup after loading the view.
    }
    
    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    
    func numberOfSections(in tableView: UITableView) -> Int {
        return 1
    }
    
    func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return dato.count
    }
    
    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell=listTableView.dequeueReusableCell(withIdentifier: "cellDato") as UITableViewCell?
        cell?.textLabel?.text=dato[indexPath.row]
        return cell!
    }
    
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        let vc = segue.destination as? ViewController
        vc?.lista=dato
        
    }
}

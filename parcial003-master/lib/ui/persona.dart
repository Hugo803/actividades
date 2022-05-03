import 'package:pacial03/api/personajes.dart';
import 'package:flutter/material.dart';


class Persona extends StatelessWidget {
  Personajes personajes;
  Persona({required this.personajes}): super();


   @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.black,
        title: Text(this.personajes.name),
      ),
      body: ListView(
        padding: EdgeInsets.all(15.0),
        children: <Widget>[

          Text(this.personajes.name,style: TextStyle(fontSize: 35) ),
          Text('Nacimiento:'+this.personajes.birthyear,style: TextStyle(fontSize: 25)),
          Text('Genero:'+this.personajes.gender,style: TextStyle(fontSize: 25))
          ,
          Text('Ojos:'+this.personajes.eyecolor,style: TextStyle(fontSize: 25))
          ,
          Text('Cabello:'+this.personajes.haircolor,style: TextStyle(fontSize: 25))
          ,
          Text('Altura:'+this.personajes.height,style: TextStyle(fontSize: 25))
          ,
          Text('Peso:'+this.personajes.mass,  style: TextStyle(fontSize: 25)),
          

        ],       
      ),
    ) ;
  }


}
import 'package:pacial03/api/personajes.dart';
import 'package:flutter/material.dart';
import 'package:pacial03/ui/persona.dart';

class CajaPersonaje extends StatelessWidget {


  Personajes personajes;

  CajaPersonaje({required this.personajes});

   @override
  Widget build(BuildContext context) {
    return ListTile(
      title: Text(this.personajes.name),
      subtitle: Text(this.personajes.gender),
      onTap: ()
      {Navigator.push(context, MaterialPageRoute(builder: (context) => Persona (personajes: this.personajes))); },
    ) ;
  }
}

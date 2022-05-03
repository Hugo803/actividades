import 'package:pacial03/api/personajes.dart';


class Characters {

  Characters();

  static List<Personajes> fromJsonList(List<dynamic> jsonList){
    List<Personajes> listaPersonajes=[];

    if (jsonList != null) {
      for (var personaje in jsonList) {

        final personajes = Personajes.fromJson(personaje);
        listaPersonajes.add(personajes);
        
      }
      
    }
    return listaPersonajes;


  }
}


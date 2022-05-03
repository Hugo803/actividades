import 'package:pacial03/api/personajes.dart';
import 'package:pacial03/api/characters.dart';
import 'dart:convert';
import 'package:http/http.dart' as http;
import 'package:pacial03/main.dart';


class Parcial03service{

  static String API_url = "https://swapi.dev/api/people/?format=json";

  static Future<List<Personajes>> getPeople() async {
    var url = API_url;
    final respuesta = await http.get(Uri.parse(url));

    if (respuesta.statusCode == 200) {
      final respuestaJSON = json.decode (respuesta.body);
      final personajesObtenidos = Characters.fromJsonList(respuestaJSON['results']);
      return personajesObtenidos;
    
    }
    return <Personajes>[];

  }


}
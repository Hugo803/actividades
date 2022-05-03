import 'dart:convert';

class Personajes{

  String name;
  String height;
  String mass;
  String haircolor;
  String skincolor;
  String eyecolor;
  String birthyear;
  String gender;
  


  Personajes({

    required this.name,
    required this.height,
    required this.mass,
    required this.haircolor,
    required this.skincolor,
    required this.eyecolor,
    required this.birthyear,
    required this.gender

  });

  static Personajes fromJson(Map<String, dynamic> json){
    return Personajes(
      
      height: json['height'] as String,
      mass: json['mass'] as String,
      name: json['name'] as String,
      haircolor: json['hair_color'] as String,
      skincolor: json['skin_color'] as String,
      eyecolor: json['eye_color'] as String,
      birthyear: json['birth_year'] as String,
      gender: json['gender'] as String,
      
      
    );
  }




}
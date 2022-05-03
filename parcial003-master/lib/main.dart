import 'package:flutter/material.dart';
import 'package:pacial03/api/parcial03service.dart';
import 'package:pacial03/ui/cajaPersonaje.dart';
import 'package:pacial03/ui/spinnerwidget.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        
        primarySwatch: Colors.blue,
      ),
      home:  apipage(),
    );
  }
}

class apipage extends StatelessWidget{

  

 @override
  Widget build(BuildContext context) {
    return Scaffold(
appBar: AppBar(backgroundColor: Color.fromARGB(255, 0, 0, 0),
      elevation: 0,
      title: Padding(
        padding: const EdgeInsets.only(left: 10, bottom:20, top: 10, right: 10),
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Text(
              "StarWars API-Personajes ",
              style: TextStyle(
                  fontSize: 20,
                  color: Color.fromARGB(255, 255, 238, 0),
                  fontWeight: FontWeight.bold),
            ),
            Container(
      height: 40.0,
      width: 40.0,
      decoration: BoxDecoration(
        image: DecorationImage(
          image: AssetImage(
              'assets/image/st3.jpeg'),
          fit: BoxFit.fill,
        ),
        shape: BoxShape.circle,
      ),
    )
          ],
        ),
      ),
),
body: FutureBuilder(
  future: Parcial03service.getPeople(),
  builder: (BuildContext contex, AsyncSnapshot<List> snapshot){
    if (snapshot.hasData) {
      return ListView.builder(itemCount: snapshot.data!.length, itemBuilder: (contex, index){
        var personaje = snapshot.data![index];
        return CajaPersonaje(personajes: personaje);
      },);
      
    }else{

      return SpinnerWidget();
    }
  }
)
    ) ;
  }
}
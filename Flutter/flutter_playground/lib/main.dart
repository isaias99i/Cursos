import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: const MyHomePage(title: 'Flutter Demo Home Page'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {

    final names = ['Isaias', 'Rickele', 'Larissa', 'Ysa', 'Carla', 'Ana'];

    return Scaffold(
      appBar: AppBar(
        title: const Text('Curso Flutterando'),
      ),
      body: SizedBox(
        width: double.infinity,
        height: double.infinity,
        child: ListView.builder(
            itemCount: names.length,
            itemBuilder: (context, index){
            final name = names[index];
              return ListTile(
                title: Text(name),
              );             
            },
          ),
        ),
    );
  }
}

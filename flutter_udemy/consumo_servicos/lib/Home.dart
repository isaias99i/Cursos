import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  TextEditingController _controllerCep = TextEditingController();
  String _resultado = "Resultado";

  _recuperarCep() async {
    String cepDigitado = _controllerCep.text;
    String url = "https://viacep.com.br/ws/${cepDigitado}/json/";
    http.Response response;

    response = await http.get(url);
    Map<String, dynamic> retorno = json.decode(response.body);
    String logradouro = retorno["logradouro"];
    String bairro = retorno["bairro"];
    String localidade = retorno["localidade"];
    String uf = retorno["uf"];
    print("Estou aqui");
    print(logradouro.toString());
    //Bugado
    setState(() {
      _resultado = "${logradouro}";
    });

  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Consumo de Serviço WEB"),
      ),
      body: Container(
        padding: EdgeInsets.all(40),
        child: Column(
          children: <Widget>[
            TextField(
              keyboardType: TextInputType.number,
              decoration: InputDecoration(
                  labelText: "Digite o CEP"
              ),
              style: TextStyle(
                fontSize: 20
              ),
              controller: _controllerCep,
            ),

            RaisedButton(
              child: Text("Clique aqui"),
              onPressed: _recuperarCep,
            ),
            Text(_resultado)
          ],
        ),
      ),
    );
  }
}
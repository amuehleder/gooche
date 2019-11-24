import 'package:flutter/cupertino.dart';
import 'package:http/http.dart' as http;

Future<String> fetchPost(String uri) async{
  final response =
      await http.get(uri);
   if (response.statusCode == 200) {
    // If server returns an OK response, parse the JSON.
    return response.body;
  } else {
    // If that response was not OK, throw an error.
    throw Exception('Failed to load post');
  }
}
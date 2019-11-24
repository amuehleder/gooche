import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:hello_world/httpHandler.dart';

TextEditingController nameController = new TextEditingController();

class MenuCreator extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Second Route"),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: CreateEntries(context),
        ),
      ),
    );
  }
}


String Test(){
  return 'Name des Gerichts';
}

List<Widget> CreateEntries(BuildContext context)
{
  return <Widget>[
    TextFormField(
      controller: nameController,
              decoration: InputDecoration(
                hintText: Test(),
                labelText: ('Name des Gerichts')
              ),
            ),
            RaisedButton(onPressed: () => SubmitForm(context), 
            child:Text('Submit Food'),
            ),
            RaisedButton(
          onPressed: () {
            Navigator.pop(context);
          },
          child: Text('Go back!'),
        ),
  ];
}

void SubmitForm(BuildContext context)
{
  showDialog(
    context: context,
    builder:(BuildContext context){
      return AlertDialog(
        title:new Text('Zusammenfassung'),
        content: FutureBuilder<String>(
            future: fetchPost('http://10.0.2.2:7071/api/Function1'),
            builder: (context, snapshot) {
              if (snapshot.hasData) {
                return Text('Returned from API:'+snapshot.data);
              } else if (snapshot.hasError) {
                return Text("${snapshot.error}");
              }

              // By default, show a loading spinner.
              return CircularProgressIndicator();
            },
          ),
        actions: <Widget>[
          new FlatButton(
            child: new Text('schließen'),
            onPressed: (){
              Navigator.of(context).pop();
            },
          )
        ],
      );
    }
  );
}
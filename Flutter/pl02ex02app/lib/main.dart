import 'dart:math';
import 'package:flutter/material.dart';
import 'widgets/widget_score_table.dart';
import 'widgets/widget_app_choice_image.dart';
import 'game_config.dart';

void main() {
  runApp(const MyApp());
}

// App root widget
class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: const MyHomePage(),
      debugShowCheckedModeBanner: false,
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({super.key});

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  String textResult = "Choose:";
  Choice? appChoice;
  Choice? userChoice;

  int gamesWon = 0;
  int gamesLost = 0;
  int gamesPlayed = 0;

  bool uiIsBlocked = false;
  bool playing = false;

  void verifyWinner() {
    if (appChoice == userChoice && playing) {
      textResult = "Draw!";
    } else if (appChoice == Choice.rock && userChoice == Choice.paper ||
        appChoice == Choice.paper && userChoice == Choice.scissors ||
        appChoice == Choice.scissors && userChoice == Choice.rock) {
      textResult = "You win!";
      gamesWon++;
    } else {
      textResult = "You lose!";
      gamesLost++;
    }

    gamesPlayed++;

    setState(() {
      uiIsBlocked = true;
    });

    Future.delayed(const Duration(seconds: 1), () {
      setState(() {
        textResult = "Choose:";
        playing = false;
        appChoice = null;
        userChoice = null;
        uiIsBlocked = false;
      });
    });
  }

  void playGame(Choice choice) {
    if (uiIsBlocked) return;
    setState(() {
      userChoice = choice;
      appChoice =
          // Generates a number between 1 and 3
          Choice.values[Random().nextInt(3)];
      playing = true;
      verifyWinner();
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.white,
      appBar: AppBar(title: Text("Rock, paper, scissors")),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            if (appChoice != null) Text("App choice:"),

            const SizedBox(height: 20),
            ChoiceImage(choice: appChoice, size: 100),
            const SizedBox(height: 50),
            Text(textResult),
            const SizedBox(height: 20),
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: <Widget>[
                for (Choice choice in Choice.values)
                  GestureDetector(
                    onTap: () => playGame(choice),
                    child: ChoiceImage(choice: choice, size: 100),
                  ),
              ],
            ),
            const SizedBox(height: 20),
            ScoreTable(
              gamesWon: gamesWon,
              gamesLost: gamesLost,
              gamesPlayed: gamesPlayed,
            ),
          ],
        ),
      ),
    );
  }
}

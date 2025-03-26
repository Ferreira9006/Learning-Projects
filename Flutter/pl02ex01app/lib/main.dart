import 'package:flutter/material.dart';

void main() {
  runApp(const PL02Ex01App());
}

class PL02Ex01App extends StatelessWidget {
  const PL02Ex01App({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(home: const PL02Ex01HomePage());
  }
}

class PL02Ex01HomePage extends StatefulWidget {
  const PL02Ex01HomePage({super.key});

  @override
  _PL02Ex01HomePageState createState() => _PL02Ex01HomePageState();
}

class _PL02Ex01HomePageState extends State<PL02Ex01HomePage> {
  int participants = 0;
  int maxParticipants = 20;

  void pressedJoin() {
    if (participants < maxParticipants) {
      setState(() {
        participants++;
      });
    }
  }

  void pressedLeave() {
    if (participants > 0) {
      setState(() {
        participants--;
      });
    }
  }

  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.white,
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            const Text(
              'Team Meeting',
              style: TextStyle(fontSize: 24, color: Colors.blue),
            ),
            const SizedBox(height: 20), // Add a space between the texts
            Text(
              "$participants",
              style: TextStyle(
                fontSize: 60,
                color: Colors.black,
                fontWeight: FontWeight.w600,
              ),
            ),
            const SizedBox(height: 30),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                TextButton(
                  onPressed:
                      (participants < maxParticipants) ? pressedJoin : null,
                  style: TextButton.styleFrom(
                    backgroundColor: const Color.fromARGB(226, 211, 243, 249),
                    foregroundColor: Colors.black,
                    fixedSize: const Size(100, 100),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(20),
                    ),
                  ),
                  child: const Text("JOIN", style: TextStyle(fontSize: 11)),
                ),
                const SizedBox(width: 20),
                TextButton(
                  onPressed: (participants > 0) ? pressedLeave : null,
                  style: TextButton.styleFrom(
                    backgroundColor: const Color.fromARGB(225, 223, 243, 247),
                    foregroundColor: Colors.black,
                    fixedSize: const Size(100, 100),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(20),
                    ),
                  ),
                  child: const Text("LEAVE", style: TextStyle(fontSize: 11)),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}

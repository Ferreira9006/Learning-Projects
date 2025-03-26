import 'package:flutter/material.dart';

class ScoreTable extends StatelessWidget {
  final int gamesWon;
  final int gamesLost;
  final int gamesPlayed;

  const ScoreTable({
    super.key,
    required this.gamesWon,
    required this.gamesLost,
    required this.gamesPlayed,
  });

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(20),
      child: Table(
        border: TableBorder.all(),
        defaultVerticalAlignment: TableCellVerticalAlignment.middle,
        children: [
          TableRow(
            children: [
              TableCell(child: Center(child: Text("Wins"))),
              TableCell(child: Center(child: Text("Losses"))),
              TableCell(child: Center(child: Text("Draws"))),
              TableCell(child: Center(child: Text("Total"))),
            ],
          ),
          TableRow(
            children: [
              TableCell(child: Center(child: Text("$gamesWon"))),
              TableCell(child: Center(child: Text("$gamesLost"))),
              TableCell(
                child: Center(
                  child: Text("${gamesPlayed - gamesWon - gamesLost}"),
                ),
              ),
              TableCell(child: Center(child: Text("$gamesPlayed"))),
            ],
          ),
        ],
      ),
    );
  }
}

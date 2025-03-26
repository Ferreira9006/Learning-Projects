import 'package:flutter/material.dart';
import '../game_config.dart';

class ChoiceImage extends StatelessWidget {
  final Choice? choice;
  final double? size;

  const ChoiceImage({super.key, required this.choice, this.size});

  @override
  Widget build(BuildContext context) {
    if (choice == null) return const SizedBox(width: 100, height: 100);

    String imagePath = "";
    switch (choice) {
      case Choice.rock:
        imagePath = "assets/images/pedra.jpg";
        break;
      case Choice.paper:
        imagePath = "assets/images/papel.jpg";
        break;
      case Choice.scissors:
        imagePath = "assets/images/tesoura.jpg";
        break;
      default:
        return const SizedBox.shrink();
    }
    return Image.asset(imagePath, height: size);
  }
}

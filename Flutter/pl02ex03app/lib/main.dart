import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: BmiCalculator(),
      debugShowCheckedModeBanner: false,
    );
  }
}

class BmiCalculator extends StatefulWidget {
  const BmiCalculator({super.key});

  @override
  BmiCalculatorState createState() => BmiCalculatorState();
}

class BmiCalculatorState extends State<BmiCalculator> {
  String bmiResult = '';

  final formKey = GlobalKey<FormState>();
  final TextEditingController weightInKgController = TextEditingController();
  final TextEditingController heightInCmController = TextEditingController();

  String bmiCategory(double bmi) {
    String bmiCategory = '';
    if (bmi < 18.5) return 'Underweight';
    if (bmi >= 18.5 && bmi < 24.9) return 'Normal weight';
    if (bmi >= 25 && bmi < 29.9) return 'Overweight';
    if (bmi >= 30) return 'Obesity';

    return bmiCategory;
  }

  String? validateInputs(String? value, String label) {
    if (value == null ||
        value.isEmpty ||
        value == '0' ||
        RegExp(r'[A-Za-z]').hasMatch(value)) {
      return 'Please enter your $label.';
    }

    return null;
  }

  void calculateMass() {
    if (!formKey.currentState!.validate()) {
      return;
    }

    double weight = double.parse(weightInKgController.text);
    double height = double.parse(heightInCmController.text) / 100;
    double bmi = weight / (height * height);

    setState(() {
      bmiResult = '${bmiCategory(bmi)} (${bmi.toStringAsFixed(2)})';
    });
  }

  @override
  void dispose() {
    weightInKgController.dispose();
    heightInCmController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('BMI Calculator'), centerTitle: true),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            Padding(
              padding: const EdgeInsets.all(20),
              child: Image.asset('assets/images/BMI.png'),
            ),
            const SizedBox(height: 10),
            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 20),
              child: Form(
                key: formKey,
                child: Column(
                  children: <Widget>[
                    TextFormField(
                      textInputAction: TextInputAction.next,
                      controller: weightInKgController,
                      keyboardType: TextInputType.number,
                      decoration: InputDecoration(
                        border: OutlineInputBorder(),
                        labelText: 'Weight (kg)',
                      ),
                      validator: (value) {
                        return validateInputs(value, 'weight');
                      },
                    ),
                    const SizedBox(height: 5),
                    TextFormField(
                      controller: heightInCmController,
                      keyboardType: TextInputType.number,
                      decoration: InputDecoration(
                        border: OutlineInputBorder(),
                        labelText: 'Height (cm)',
                      ),
                      validator: (value) {
                        return validateInputs(value, 'height');
                      },
                    ),
                    const SizedBox(height: 20),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                      children: <Widget>[
                        ElevatedButton(
                          onPressed: () {
                            calculateMass();
                          },
                          child: const Text('Calculate BMI'),
                        ),
                        ElevatedButton(
                          onPressed: () {
                            weightInKgController.clear();
                            heightInCmController.clear();
                            setState(() {
                              bmiResult = '';
                            });
                          },
                          child: const Text('Reset'),
                        ),
                      ],
                    ),
                    const SizedBox(height: 20),
                    Visibility(
                      visible: bmiResult.isNotEmpty,
                      child: Text(
                        bmiResult,
                        style: TextStyle(
                          fontSize: 18,
                          fontWeight: FontWeight.bold,
                        ),
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}

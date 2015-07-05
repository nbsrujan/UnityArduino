/*
  Analog input, analog output, serial output
 
 Reads an analog input pin, Also prints the results to the serial monitor.
 
 The circuit:
 * potentiometer connected to analog pin 0.
   Center pin of the potentiometer goes to the analog pin.
   side pins of the potentiometer go to +5V and ground

 
created 24th march
 by Srujan Babu 
  */
 
 const int analogInPin = A0;
 int sensorValue = 0;
 
void setup()
{
  Serial.begin(9600);
}

void loop()
{
  sensorValue = analogRead(analogInPin);
  Serial.println(sensorValue);
  Serial.flush();
  delay(20);
}

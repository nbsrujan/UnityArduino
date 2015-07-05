const int pushButton01 = 7;
const int pushButton02 = 8;

void setup()
{
  Serial.begin(9600);
  pinMode(pushButton01,INPUT);
  pinMode(pushButton02,INPUT);
}

void loop()
{
   int buttonState01 = digitalRead(pushButton01);
   int buttonState02 = digitalRead(pushButton02);
    if(buttonState01==1){
      Serial.write(1);
      Serial.flush();
      delay(20);
    }
    if(buttonState02==1){
       Serial.write(2);
       Serial.flush();
       delay(20);
    }
   delay(1); 
}

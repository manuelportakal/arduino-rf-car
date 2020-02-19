#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>
RF24 radio(7, 8); // CE, CSN
const byte address[][6] = {"00001", "00002"};
char text;
float veri; 

void setup() {
  Serial.begin(9600); 
  radio.begin();
  radio.openWritingPipe(address[1]);
  radio.openReadingPipe(1, address[0]);
  radio.setPALevel(RF24_PA_MIN);
}

void veriAl(){
   radio.startListening();
   radio.read(&veri, sizeof(veri));
   Serial.println(veri);
   Serial.print(" Celcius");
   delay(1000);
}

void loop() {
  radio.stopListening();
  if(Serial.available()){
    text = Serial.read();
    if(text == '0' || text == '1' || text == '2' || text == '3' || text == '4' || text == '6' || text == '7' || text == '8' || text == '9'){
      radio.write(&text, sizeof(text));
    }
    else if(text == '5'){
      radio.write(&text, sizeof(text));
      veriAl();
    }
  }
}

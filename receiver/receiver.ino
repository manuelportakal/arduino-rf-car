//Bu kisimda gerekli kutuphaneleri cagiriyoruz
#include <Servo.h> 
#include <dht11.h>
#include <SPI.h>
#include <nRF24L01.h>
#include <RF24.h>

//Bu kisimda pinleri tanimliyoruz
const int gazSensor = A0;
const int alarm = 13;
const int servo = 12;
const int sagGeri = 11;
const int sagIleri = 10;
const int solGeri = 9;
const int solIleri = 8;
const int trigPin = 5;
const int echoPin = 4;
const int sicaklikSensor = 3;
const int lazer = 2;

//Bu kisimda kullanacagimiz degiskenleri tanimliyoruz
char gelenKomut;
float gidenVeri;
long sure;
int mesafe_tmp;
int mesafe;
int uyariDegeri = 100;
unsigned long zamangidenVerisi1 = 0;
unsigned long zamangidenVerisi2 = 0;
int alarmSayac = 1;
bool alarmKarar;

//Servo motor icin bir nesne olusturuyoruz
Servo Servo1; 

//Sicaklik sensoru icin bir nesne olusturuyoruz
dht11 DHT11;

//RF icin bir nesne ve okuma,yazma icin adres bilgisi olusturuyoruz
RF24 radio(6, 7); // CE, CSN
const byte address[][6] = {"00001", "00002"};

void setup() {
  //Pinlerimizin giris-cikis ayarini yapiyoruz
  pinMode(sagIleri, OUTPUT);
  pinMode(sagGeri, OUTPUT);
  pinMode(solIleri, OUTPUT);
  pinMode(solGeri, OUTPUT);
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
  pinMode(lazer, OUTPUT);
  digitalWrite(lazer, HIGH);
  pinMode(gazSensor, INPUT);
  pinMode(alarm, OUTPUT);
  
  Servo1.attach(servo);

  Serial.begin(9600);
  radio.begin();
  radio.openReadingPipe(1, address[1]);
  radio.openWritingPipe(address[0]);
  radio.setPALevel(RF24_PA_MIN);
  radio.startListening();
}

void dur(){
    digitalWrite(sagIleri, LOW);
    digitalWrite(sagGeri, LOW);
    digitalWrite(solIleri, LOW);
    digitalWrite(solGeri, LOW);
    Serial.println("Yön: Dur");
  }
  
void ileri(){
    mesafe = mesafeOlc();
    Serial.println(mesafe);
    if(mesafe > 30){
        digitalWrite(sagIleri, HIGH);
        digitalWrite(sagGeri, LOW);
        digitalWrite(solIleri, HIGH);
        digitalWrite(solGeri, LOW);
        Serial.println("Yön: ileri ");
    }
    else{
        Serial.println("Opps!");
        zamangidenVerisi2 = millis();
        engelGec();
    }
}
  
void geri(){
    digitalWrite(sagIleri, LOW);
    digitalWrite(sagGeri, HIGH);
    digitalWrite(solIleri, LOW);
    digitalWrite(solGeri, HIGH);
    Serial.println("Yön: Geri");
}

void sol(){
    mesafe = mesafeOlc();
    Serial.println(mesafe);
    if(mesafe > 20){
      digitalWrite(sagIleri, HIGH);
      digitalWrite(sagGeri, LOW);
      digitalWrite(solIleri, LOW);
      digitalWrite(solGeri, LOW);
      Serial.println("Yön: Sol");
    }
     else{
      dur();
      delay(1000);
      Serial.println("Opps!");
      zamangidenVerisi2 = millis();
      engelGec();
    }
}

void sag(){
   mesafe = mesafeOlc();
   Serial.println(mesafe);
   if(mesafe > 20){
      digitalWrite(sagIleri, LOW);
      digitalWrite(sagGeri, LOW);
      digitalWrite(solIleri, HIGH);
      digitalWrite(solGeri, LOW);
      Serial.println("Yön: Sag");
   }
    else{
      Serial.println("Opps!");
      zamangidenVerisi2 = millis();
      engelGec();
    }
}

void veriGonder(){
   radio.stopListening();
   int chk = DHT11.read(sicaklikSensor);
   //Serial.print("Nem (%): ");
   //Serial.println((float)DHT11.humidity, 2);
   //Serial.print("Sicaklik (Celcius): ");
   //Serial.println((float)DHT11.temperature, 2);
   //Serial.print("Cig Olusma Noktasi: ");
   //Serial.println(DHT11.dewPoint(), 2);
   gidenVeri = (float)DHT11.temperature;
   Serial.println(gidenVeri);
   radio.write(&gidenVeri, sizeof(gidenVeri));
}

int mesafeOlc(){
   digitalWrite(trigPin, LOW);
   delayMicroseconds(2);
   digitalWrite(trigPin, HIGH);
   delayMicroseconds(10);
   digitalWrite(trigPin, LOW);
   sure = pulseIn(echoPin, HIGH);
   mesafe_tmp= sure*0.034/2;
   //Serial.print("mesafe_tmp: ");
   //Serial.println(mesafe_tmp);
   Serial.print("Engel mesafesi: ");
   return mesafe_tmp;
 }
 
void engelGec(){
   Serial.println("Engel Geciliyor..");
    while(millis() - zamangidenVerisi2 < 150)
       geri();
    dur();
    while(millis() - zamangidenVerisi2 < 300)
       sag();
    dur();
    while(millis() - zamangidenVerisi2 < 700)
       ileri();
    dur();
}

int alarmAcKapa(){
    if(alarmSayac % 2 == 0){
      //Serial.println("alarm aktif, sayac: ");
      //Serial.print(alarmSayac);
      digitalWrite(alarm, HIGH);
      alarmSayac++;
      return 0;
    }
    else{
      digitalWrite(alarm, LOW);
      //Serial.println("alarm pasif, sayac: ");
      //Serial.print(alarmSayac);
      alarmSayac++;
      return 1;
    }
  }


void loop() {
   
   int okunan_gazSensor = analogRead(gazSensor);
   //Serial.print("Pin A0: ");
   //Serial.println(okunan_gazSensor);
   if(okunan_gazSensor > uyariDegeri  )
   {
    digitalWrite(alarm, HIGH);
   }
   else if(okunan_gazSensor <= uyariDegeri){
      alarmKarar = alarmAcKapa();
      if(alarmKarar == 1)
        digitalWrite(alarm, LOW);
      alarmSayac++;
    }

   delay(100);

   radio.startListening(); 
   if (radio.available()){
      radio.read(&gelenKomut, sizeof(char));
      Serial.print("Gelen Komut: ");
      Serial.println(gelenKomut);
      zamangidenVerisi1 = millis();

      if(gelenKomut == '0'){
        dur();
      }

      else if(gelenKomut == '1'){
        while(millis() - zamangidenVerisi1 < 1500){
          ileri();
        }
        dur();
      }

      
      else if(gelenKomut == '2'){
        while(millis() - zamangidenVerisi1 < 305){
            sol();
        }
        dur();
        while(millis() - zamangidenVerisi1 < 610){
            ileri();
        }
        dur();
      }
      
      else if(gelenKomut == '3'){
        while(millis() - zamangidenVerisi1 < 305){
          sag();
        }
        dur();
        while(millis() - zamangidenVerisi1 < 610){
          ileri();
        }
        dur();
      }

      else if(gelenKomut == '4'){
        while(millis() - zamangidenVerisi1 < 500){
          geri();
        }
        dur();
      }
      
      else if(gelenKomut == '5'){
        veriGonder();
      }
      
      else if(gelenKomut == '6'){
        Servo1.write(180);
        Serial.println("servo 0°");
      }
       
      else if(gelenKomut == '7'){
        Servo1.write(0);
        Serial.println("servo 180°");
      }
      
      else if(gelenKomut == '8'){
        Servo1.write(90);
        Serial.println("servo 90°");
      }

      else if(gelenKomut == '9'){
        alarmAcKapa();
      }
  }
}

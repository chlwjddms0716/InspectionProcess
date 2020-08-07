#include "DHT.h"
#define DHTPIN 2 
#define DHTTYPE DHT11 
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  Serial.begin(9600);
  dht.begin();
}
byte senddata[4];

void loop() {

 float h = dht.readHumidity();
 float t = dht.readTemperature();
  
  if (isnan(h) || isnan(t)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }

  // byte 변환해서 시리얼 통신으로 보냄
  senddata[0] = (byte)((t*100)/256);
  senddata[1] = (byte)((int)(t*100)%256);
  senddata[2] = (byte)((h*100)/256);
  senddata[3] = (byte)((int)(h*100)%256);
  Serial.write(senddata,4);
  
}

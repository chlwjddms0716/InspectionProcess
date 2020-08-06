#include<Servo.h>

Servo base;
Servo shoulder;
Servo grip;

int red = 0;
int blue = 0;
int count = 0;

#define S0 10
#define S1 11
#define S2 12
#define S3 13
#define sensorOut 7

int frequencyR = 0;
int frequencyB = 0;
int frequencyG = 0;

#define TRIG 9 //TRIG 핀 설정 (초음파 보내는 핀)

#define ECHO 8 //ECHO 핀 설정 (초음파 받는 핀)
#define CONVEYOR A0
int frequency = 0;
void setup() {
  pinMode(S0, OUTPUT);
  pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  pinMode(S3, OUTPUT);
  pinMode(sensorOut, INPUT);
  
  // Setting frequency-scaling to 20%
  digitalWrite(S0,HIGH);
  digitalWrite(S1,LOW);
  
  Serial.begin(9600);


   pinMode(TRIG, OUTPUT);

  pinMode(ECHO, INPUT);

 pinMode(CONVEYOR,OUTPUT); 
  analogWrite(CONVEYOR,255);


  base.attach(3);
  shoulder.attach(5);
  grip.attach(9);
}

void loop() {
  char color;
  if(count==2){
      Serial.read();
      Serial.print(red);
      count =0;
      red =0;
      blue = 0;
  }


while(1){
 if (Serial.available())  { 
  break;
 }  
 }

  long duration, distance;



  digitalWrite(TRIG, LOW);

  delayMicroseconds(2);

  digitalWrite(TRIG, HIGH);

  delayMicroseconds(10);

  digitalWrite(TRIG, LOW);



  duration = pulseIn (ECHO, HIGH); //물체에 반사되어돌아온 초음파의 시간을 변수에 저장합니다.





  //34000*초음파가 물체로 부터 반사되어 돌아오는시간 /1000000 / 2(왕복값이아니라 편도값이기때문에 나누기2를 해줍니다.)

 //초음파센서의 거리값이 위 계산값과 동일하게 Cm로 환산되는 계산공식 입니다. 수식이 간단해지도록 적용했습니다.

  distance = duration * 17 / 1000; 







  //PC모니터로 초음파 거리값을 확인 하는 코드 입니다.

  /*Serial.println(duration ); //초음파가 반사되어 돌아오는 시간을 보여줍니다.

  Serial.print("\nDIstance : ");

  Serial.print(distance); //측정된 물체로부터 거리값(cm값)을 보여줍니다.

  Serial.println(" Cm");
  */



  delay(1000); //1초마다 측정값을 보여줍니다.

 if(distance < 10)
  {
    
    analogWrite(CONVEYOR,0);
     delay(2000);
    analogWrite(CONVEYOR,255);
  
  digitalWrite(S2,LOW);
  digitalWrite(S3,LOW);
  frequencyR = pulseIn(sensorOut, LOW);
  delay(100);

    if (frequencyR > 150 )
{


color = 'b';

blue++;
count++;
  
}


else {

  color = 'r';
  
red++;
count++;

}
Serial.println(color);
      delay(2000);




      
analogWrite(CONVEYOR,0);
delay(2300);
analogWrite(CONVEYOR,255);
if(color == 'r')
{
  grip.write(0); // 손 벌리고
delay(1000);
 
shoulder.write(120); // 내려가고
delay(1000);

grip.write(160); // 손 집고
delay(1000);

shoulder.write(60); // 올라오고
delay(1000);

base.write(180); // 왼쪽으로 비틀고
delay(1000);

shoulder.write(120); // 내려가고
delay(1000);


grip.write(50); // 손 벌리고
delay(1000);

base.write(90); // 다시 원상태로
delay(1000);
}

else {
  grip.write(0); // 손 벌리고
delay(1000);
 
shoulder.write(120); // 내려가고
delay(1000);

grip.write(160); // 손 집고
delay(1000);

shoulder.write(60); // 올라오고
delay(1000);
  
base.write(0); // 오른쪽으로 비틀고
delay(1000);


shoulder.write(120); // 내려가고
delay(1000);


grip.write(50); // 손 벌리고
delay(1000);


base.write(90); // 다시 원상태로
delay(1000);

  
}

      
  } else {
    analogWrite(CONVEYOR,255);
     delay(1000); 
  }




}

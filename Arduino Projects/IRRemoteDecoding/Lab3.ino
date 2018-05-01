#define IRPIN 8
#define ACTIVE 0
#define INACTIVE 1
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  timer1Init();
}

void timer1Init()
{
  TCCR1A = 0x00;
  TCCR1B = 0x05;
  TIMSK1 = 0x00;
  TCNT1 = 0x00;
}

void checkForIRInput()
{
  while(digitalRead(IRPIN)==INACTIVE);

    TCNT1=0x00;
   while(digitalRead(IRPIN)==ACTIVE);
   float countActive=TCNT1;
   TCNT1=0x00;
   while(digitalRead(IRPIN)==INACTIVE);
   float countInactive=TCNT1;
   TCNT1=0x00;
   countActive=countActive*0.064f;
   countInactive=countInactive*0.064f;
      //Serial.print("Active Count(msec):");
    //Serial.println(countActive);
   //Serial.print("Inactive Count(msec):");
      //Serial.println(countInactive);
   if(countActive>=7 && countActive<=10)
   {


    if(countInactive>=2 && countInactive<=2.5)
    {
      Serial.println("Repeat");

    }
    else if(countInactive>=4 && countInactive<=5)
    {
      //Serial.println("Command");
      unsigned char checkedByte[4];
      for(int i=0; i<4; i++)
      {
        checkedByte[i]=readByte();
      }
      unsigned char check=~checkedByte[0];
      unsigned char check2=~checkedByte[2];      
      if(check==checkedByte[1] && check2==checkedByte[3])      {
        Serial.println("Checked Bytes is the same");
        Serial.println(checkedByte[0],HEX);
        Serial.println(checkedByte[1],HEX);
        Serial.println(checkedByte[2],HEX);
        Serial.println(checkedByte[3],HEX);
      }
      else
      {
        Serial.println("Checked Byte is wrong:");
        Serial.println(checkedByte[0],HEX);
        //Serial.println(~checkedByte[0],BIN);
        Serial.println(checkedByte[1],HEX);
        Serial.println(checkedByte[2],HEX);
        Serial.println(checkedByte[3],HEX);
      }
    }
    else
    {
      Serial.println("Something is wrong with the inactive count");
    }
   }
   else
   {
    Serial.println("Something is wrong with the active count:");
    Serial.println(countActive);
   }
   while(digitalRead(IRPIN)==ACTIVE);
}
int readBit()
{
  int inactCnt ;
  float inactTime ;
  
  while(digitalRead(IRPIN)==ACTIVE);
  TCNT1=0x00;
  while(digitalRead(IRPIN)==INACTIVE);
  inactCnt=TCNT1;
  inactTime=inactCnt*64.0f;
  //Serial.print("inactTime: ");
  //Serial.println(inactTime);
  if(inactTime>=448.0 && inactTime<=680.0)
    return 0;
  else if(inactTime>=1550.0 &&  inactTime<=1800.0)
    return 1;
  else
  {
    Serial.println("Failure on readBit");
    return inactCnt;
  }

}

unsigned char readByte()
{
  unsigned char code=0x00;
  int abit;
  for(int i=0; i<8; i++)
  {
    abit=readBit();
    //Serial.print("Bit #");
    //.print(i);
    //Serial.print(": ");
    //Serial.println(abit);
    if(abit>1) {
       Serial.print("Bit error, inactive cnt = ") ;
       Serial.println(abit) ;      
    }
    else
      code=code|(abit<<i);
  }

  return code;
}
void loop() {
  // put your main code here, to run repeatedly:
  checkForIRInput();
  //delay(500);

}

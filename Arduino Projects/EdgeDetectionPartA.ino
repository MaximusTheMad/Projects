#include <ARTK.h>

SEMAPHORE artkSema;

void Setup() {
  pinMode(2, INPUT_PULLUP);
  artkSema=ARTK_CreateSema(0);
  ARTK_CreateTask(busy,1);
  ARTK_CreateTask(switchMonitor,3);
  ARTK_CreateTask(consumer,2);
  

}

char computeChar() {
  char c = random(33,127) ;
  int del = random(500, 2500) ;
  delay(del) ;
  return c ;
}

void switchMonitor()
{
  int switchstate = 1 ;
  Printf("Hello from monitor\n") ;
  while(true)
  {
    int newswitch = digitalRead(2) ;
    if(newswitch==0 && switchstate==1)
    {      
      ARTK_SignalSema(artkSema);
    }
    switchstate = newswitch;
    ARTK_Sleep(20);
  }
}

void busy()
{
  Printf("Hello from busy\n") ;
  while(1)
  {
    char c=computeChar();
    Printf("char =%c\n",c);
  }
}

void consumer()
{
  int numPresses=0;
  Printf("Hello from consumer\n") ;
  while(numPresses<6)
  {
    ARTK_WaitSema(artkSema);
    numPresses++;
   Printf("Button has been pressed.  Number of times pressed = %d\n",numPresses); 
   ARTK_Sleep(2);
   
  }
  ARTK_TerminateMultitasking();
}


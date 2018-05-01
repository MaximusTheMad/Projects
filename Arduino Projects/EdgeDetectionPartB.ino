#include <ARTK.h>

SEMAPHORE artkSema;

void Setup() {
  artkSema=ARTK_CreateSema(0);
  ARTK_CreateTask(busy,2);
  ARTK_CreateTask(signalSemaphore,1);
  ARTK_CreateTask(consumeSemaphore,3);
  

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
    Printf("%c\n",c);
    ARTK_Sleep(1);
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
void consumeSemaphore()
{
  for(int i=0; i<3; i++)
  {
    Printf("H Waiting for %d\n",i);
    ARTK_WaitSema(artkSema);
    Printf("H Acquired %d\n", i);
  }
  ARTK_TerminateMultitasking();
}
void signalSemaphore()
{
  while(true)
  {
  Printf("L Signalling\n");
  ARTK_SignalSema(artkSema);
  }
}


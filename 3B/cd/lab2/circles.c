#include <graphics.h>
#include <conio.h>

void main(){

int gd = DETECT,gm,x=400,y=400;
   initgraph(&gd,&gm,"");
   rectangle(100,100,400,300);
   floodfill(101,101,15);
   
   rectangle(200,150,300,250);
   floodfill(201,151,1);
   
   circle(250,200,100);
   floodfill(251,201,4);
   
   circle(250,200,10);
   floodfill(251,201,14);
   getch();
   closegraph();
}
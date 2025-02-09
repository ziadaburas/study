#include <graphics.h>
#include <conio.h>

void main(){

int gd = DETECT,gm,x=400,y=400;
   initgraph(&gd,&gm,"");
   int i;
   for( i=100;i<300;i++){
   putpixel(i,100,15);
   putpixel(i,200,15);
   }
   for( i=100;i<200;i++){
   putpixel(100,i,15);
   putpixel(300,i,15);
   }
   getch();
   closegraph();
}
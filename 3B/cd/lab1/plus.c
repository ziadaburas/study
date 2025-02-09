#include <graphics.h>
#include <conio.h>

void main(){

int gd = DETECT,gm,x=400,y=400;
   initgraph(&gd,&gm,"");
   int i;
   for( i=0;i<x;i++)
   putpixel(i,y/2,15);
   for( i=0;i<x;i++)
   putpixel(x/2,i,15);
   getch();
   closegraph();
}
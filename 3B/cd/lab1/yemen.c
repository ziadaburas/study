#include <graphics.h>
#include <conio.h>

void main(){

int gd = DETECT,gm,x=400,y=400;
   initgraph(&gd,&gm,"");
   setbkcolor(1);
   int ye[]={4,15,0};
   
   setbkcolor(1);
   for(int i=0;i<3;i++){
    setcolor(ye[i]);
    for(int j=0;j<50;j++){
     int x1=100,x2=300;
     int y1=((i+1)*50)+j;
     line(100,y1,300,y1);
    }
   }
   
   getch();
   closegraph();
}
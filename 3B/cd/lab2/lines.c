#include <graphics.h>
#include <conio.h>

void main(){

int gd = DETECT,gm,x=400,y=400;
   initgraph(&gd,&gm,"");
   int i;
   for(i=0;i<4;i++){
    setlinestyle(i,0,1);
    int x1=20,x2=40;
    int y1=(i+1)*20;
    line(x1,y1,x2,y1);
   }
   for(i=0;i<13;i++){
    setlinestyle(0,i,1);
    int x1=50,x2=70;
    int y1=(i+1)*20;
    line(x1,y1,x2,y1);
   }
   
   setlinestyle(0,1,1);
   line(80,20,100,20);
   
   setlinestyle(0,1,3);
   line(80,40,100,40);
   
   getch();
   closegraph();
}
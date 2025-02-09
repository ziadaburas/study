#include <graphics.h>
#include <conio.h>
char * getMyColor(char * t,int i){
 char colors[16][20] = {
    "black", "blue", "green", "cyan", "red", "magenta", "brown", "lightgray",
    "darkgray", "lightblue", "lightgreen", "lightcyan", "lightred", "lightmagenta", 
    "yellow",  "white"
};
    char arr[25] ={};
    int j;
    for( j=0;t[j] !='\0';j++)
    arr[j]=t[j];
   
    for( int k=0;colors[i][k] !='\0';k++)
    arr[j+k]=colors[i][k];
    return arr;
}
 
void main(){
int gd = DETECT,gm,x=400,y=400;
   initgraph(&gd,&gm,"");
  
int count=0;
char ch=50;
while(ch != 'e'){
   cleardevice();
   int bgcolor =(count+1)%16;
   int fcolor=count%16;
   setbkcolor(bgcolor);
   circle(200,200,100);
   floodfill(201,201,fcolor);
   //char * cl = getMyColor("color : ",fcolor);
   outtextxy(10,10,getMyColor("color : ",fcolor));
   outtextxy(10,30,getMyColor("background : ",bgcolor));
   count++;
   ch = getch();
}
   
   getch();
   closegraph();
}
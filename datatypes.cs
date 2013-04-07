class datatype
{
public static void Main(string[] arg)
{
bool a=4>5;
byte b=256;//error because max value is 255
char c='a';
decimal d=324;
double e=134.345;
float f=3.5f;
int g=-1233;
long h=23234243;
sbyte i=129;//range is -128 to 127 so error for 129
short j=33456;//error for going out of range
uint k=2123;
ulong l=23423;
ushort m=324;
System.Console.Write(a+" "+b+" "+c+" "+d+" "+e+" "+f+" "+g+" "+h+" "+i+" "+j+" "+k+" "+l+" "+m);
}
}

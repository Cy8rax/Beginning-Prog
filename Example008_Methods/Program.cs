int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int a1=436;
int b1=45;
int c1=455;

int a2=84;
int b2=7;
int c2=8943;

int a3=85;
int b3=9870;
int c3=4;

int max1=Max(a1,b1,c1);
int max2=Max(a2,b2,c2);
int max3=Max(a3,b3,c3);
int max=Max(max1,max2,max3);

Console.WriteLine(max);
using System;

namespace GetVariableValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Question 1: string GetX()
            //{
            string y = "mbilg";//y.Length=5;
            string x = "";
            for (int i = 0; i < y.Length; i++)
            {
                x += Convert.ToChar(y[i] - i);
            }
            //a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z;
            //i=0,y[0]-i->m-0->m;i=1,y[1]-1->b-1->a;
            //i=2,y[2]-2->i-2->g;i=3,y[3]-3->l-3->i;
            //i=4,y[4]-4->g-4->c;i=5,i=y.Length, skip the loop,print out the result:magic.
            Console.WriteLine(x);//The output is magic.
                                 //  retrun x;

            //}


            //Question 2: static bool GetX()
            //{
            bool x1;
            int a = 6;
            int b = 3;
            a = ++a;//a++first,a=7.
            b = b & 1;//b=3&1->(11)&(01)->(01)->=1.
            x1 = (a == b);//a==b->7==1?->False.
            Console.WriteLine(x1);//The output is False.
                                  //  retrun x1;
                                  //}


            //Question 3:int GetX()
            //{
            string[] arr = { "the", "quick", "brown", "fox" };
            int x2 = arr[arr.Length - 1].Length;//arr[arr.Length-1]->arr[4-1]->arr[3]->'fox'(array index base on 0)->'fox'.Length->3
            Console.WriteLine(x2);//The output is 3.
                                  //  retrun x2;
                                  //}

            //Question 4:int GetX() discrimination index.
            //{
            int[] z = { -99, 0, 1, 2, 3, 5, 8, 13, 21, 34 };
            int x3 = int.MaxValue;//C# public const int MaxValue = 2147483647;
            foreach (var y1 in z) x3 = y1 < x3 ? y1 : x3;
            //? : 运算符,用来替代if..else，Exp1 ? Exp2 : Exp3;
            //? 表达式的值是由 Exp1 决定的。
            //如果 Exp1 为真，则计算 Exp2 的值，结果即为整个 ? 表达式的值。
            //如果 Exp1 为假，则计算 Exp3 的值，结果即为整个 ? 表达式的值。
            //x3=(y1<x3?y1:x3)
            //y1=-99,-99<2147483647,True,return y1,so,x3=-99;
            //y1=0,0<-99,False,return x3,so,x3=-99;
            //y1=1,1<-99,False,return x3,so,x3=-99;
            //y1=2,2<-99,False,return x3,so,x3=-99;
            //y1=3,2<-99,Flase,return x3,so,x3=-99;
            //以此类推，foreach array all elements,the result will be x=-99;

            Console.WriteLine(x3);//The output is -99;
                                  //  retrun x3;
                                  //}      


            //Question 5:int GetX()
            //{
            int x4, y2 = 54;
            x4 = y2 % 10;//x4->54%10=4;
            x4 *= 10;//x4*10=4*10=40;
            x4 += y2 / 10;//y2/10=5;x4+5=40+5=45;
            Console.WriteLine(x4);//The output is 45;
            //  retrun x4;
            //}  


            //Question 6:string GetX()
            //{
            int happy;
            var hi = true;
            string[] dwarf = { "0:>", ":{", "x)", ":)", "|<", ":|",":/" };
            for (happy=0;happy<dwarf.Length;happy++)
                {
                 bool ho = !(hi);
                 hi=ho;
                }
            var x5 = dwarf[happy / 2] == ":)" ? "hi!" : "ho!";//happy=6->happy/2=3,dwarf[3]->:),so, "hi!"will be the output.
            Console.WriteLine(x5);//The output is hi!;
            //  retrun x5;
            //}

        }


    }
}



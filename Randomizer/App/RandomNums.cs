using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    class RandomNums
    {
        private Thread randThread;
        private int min;
        private TextBox tb;
        private int[] arr;
        public RandomNums(int n1, int n2,TextBox tbx) {
            min = n1 - 1;
            arr =new int[n2 - n1+1];
            for(int i = 0, n=n1; i <arr.Length; i++,n++) { arr[i] = n; }
            tb = tbx;
            randThread = new Thread(rand);
            randThread.IsBackground = true;
        }
        public void doRandom()
        {
            randThread.Start();
            
        }
        private void rand()
        { int l = arr.Length;
            int elem;
            Random random = new Random();
            for(int i = 0; i < l; i++) { 
           elem= random.Next(l);
               tb.Invoke((MethodInvoker)(delegate () { tb.Text += findItem(elem) + "\r\n"; }));
                  
                
            }
        }
        private int findItem(int i) {
            int res = 0;
            if (arr[i] != min) {
                res = arr[i];
                arr[i] = min;
                return res;
            }
            else while (arr[i] == min)
                {   i++;
                    if (i == arr.Length) i = 0;
                    
                }
            res = arr[i];
            arr[i] = min;
            return res;
        }
    }
}

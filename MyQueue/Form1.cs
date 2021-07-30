using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyQueue firstQueue;
        MyQueue secondQueue;
        MyQueue thirdQueue;

        int n = 21;
        int min = 1;

        private void CreateQueue_Click(object sender, EventArgs e)
        {
            create();
            firstQueue.Enqueue(2 * min);
            secondQueue.Enqueue(3 * min);
            thirdQueue.Enqueue(5 * min);
            ViewQueue();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            MinQueueElem();
        }

        void create()
        {
            firstQueue = new MyQueue(n);
            secondQueue = new MyQueue(n);
            thirdQueue = new MyQueue(n);
        }

        public void Pushing()
        {
            if ((2 * min) < n)
                firstQueue.Push(2 * min);

            if ((3 * min) < n)
                secondQueue.Push(3 * min);

            if ((5 * min) < n)
                thirdQueue.Push(5 * min);
        }

        public void ViewQueue()
        {
            ViewQueue1();
            ViewQueue2();
            ViewQueue3();
        }

        public void ViewQueue1()
        {            
            try
            {
                listBox1.Items.Clear();
                if (firstQueue.elem.Count != 0)
                {
                    for (int i = 0; i < firstQueue.elem.Count; i++)
                    {
                        listBox1.Items.Add(firstQueue.elem[i].ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("1");
            }
        }

        public void ViewQueue2()
        {
            try
            {
                listBox2.Items.Clear();
                if (secondQueue.elem.Count != 0)
                {
                    for (int i = 0; i < secondQueue.elem.Count; i++)
                    {
                        listBox2.Items.Add(secondQueue.elem[i].ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("2");
            }
        }

        public void ViewQueue3()
        {

            try
            {
                listBox3.Items.Clear();
                if (thirdQueue.elem.Count != 0)
                {
                    for (int i = 0; i < thirdQueue.elem.Count; i++)
                    {
                        listBox3.Items.Add(thirdQueue.elem[i].ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("3");
            }
        }

        public void MinQueueElem()
        {
            int f = firstQueue.Top();
            //int IndexF = listBox1.Items.IndexOf(f);
            int s = secondQueue.Top();
            //int IndexS = listBox2.Items.IndexOf(s);
            int t = thirdQueue.Top();
            //int IndexT = listBox3.Items.IndexOf(t);

            if(f != 0)
            {
                if (f < s)
                {
                    if (f < t)
                    {
                        try
                        {
                            min = firstQueue.Pop();
                            MinElem.Text = "Min\n" + min.ToString();

                           // listBox1.Items.RemoveAt(listBox1.Items.IndexOf(f));
                            Pushing();
                            ViewQueue();
                        }
                        catch
                        {

                        }

                        return;
                    }
                }
                if(f == s)
                {
                    min = firstQueue.Pop();
                    min = secondQueue.Pop();
                    MinElem.Text = "Min\n" + min.ToString();
                    Pushing();
                    ViewQueue();
                }
                if (f == t)
                {
                    min = firstQueue.Pop();
                    min = thirdQueue.Pop();
                    MinElem.Text = "Min\n" + min.ToString();
                    Pushing();
                    ViewQueue();
                }
            }

            if(s != 0)
            {
                if (s < f)
                {
                    if (s < t)
                    {
                        try
                        {
                            min = secondQueue.Pop();
                            MinElem.Text = "Min\n" + min.ToString();

                            //listBox2.Items.RemoveAt(listBox2.Items.IndexOf(s));
                            Pushing();
                            ViewQueue();
                        }
                        catch
                        {

                        }

                        return;
                    }

                    if(s == f)
                    {
                        min = firstQueue.Pop();
                        min = secondQueue.Pop();
                        MinElem.Text = "Min\n" + min.ToString();
                        Pushing();
                        ViewQueue();
                    }
                    if(s == t)
                    {
                        min = secondQueue.Pop();
                        min = thirdQueue.Pop();
                        MinElem.Text = "Min\n" + min.ToString();
                        Pushing();
                        ViewQueue();
                    }
                }
            }

            if(t != 0)
            {
                if (t < s)
                {
                    if (t < f)
                    {
                        try
                        {
                            min = thirdQueue.Pop();
                            MinElem.Text = "Min\n" + min.ToString();

                            //listBox3.Items.RemoveAt(listBox3.Items.IndexOf(t));
                            Pushing();
                            ViewQueue();
                        }
                        catch
                        {

                        }

                        return;
                    }
                }
                if(t == s)
                {
                    min = secondQueue.Pop();
                    min = thirdQueue.Pop();
                    MinElem.Text = "Min\n" + min.ToString();
                    Pushing();
                    ViewQueue();
                }
                if(t == f)
                {
                    min = firstQueue.Pop();
                    min = thirdQueue.Pop();
                    MinElem.Text = "Min\n" + min.ToString();
                    Pushing();
                    ViewQueue();
                }
            }                        
        }        
    }
}

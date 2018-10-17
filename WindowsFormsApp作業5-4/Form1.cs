using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp作業5_4
{
    public partial class form1 : Form
    {
        List<Button> myDButtonList = new List<Button>();       
        List<string> listString = new List<string>();
        List<string> listString2 = new List<string>();
        List<string> listString3 = new List<string>();
        List<string> listString4 = new List<string>();
        List<string> listString5 = new List<string>();
        List<string> listString6 = new List<string>();       
        int[] arrayRndNum = new int[12];
        int time1;
        int time2;
        int time3;
        int time4;
        int time5;
        int time6;
        int time7;
        int time8;
        int time9;
        int time10;
        int time11;
        int time12;
       
        Point Lb目前位置 = new Point();

        public form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            動態產生按鈕(6, 4);
            timer1.Interval = 33;
            timer1.Enabled = false;
            timer2.Interval = 33;
            timer2.Enabled = false;
            timer3.Interval = 33;
            timer3.Enabled = false;
            timer4.Interval = 33;
            timer4.Enabled = false;
            timer5.Interval = 33;
            timer5.Enabled = false;
            timer6.Interval = 33;
            timer6.Enabled = false;
            timer7.Interval = 33;
            timer7.Enabled = false;
            timer8.Interval = 33;
            timer8.Enabled = false;
            timer9.Interval = 33;
            timer9.Enabled = false;
            timer10.Interval = 33;
            timer10.Enabled = false;
            timer11.Interval = 33;
            timer11.Enabled = false;
            timer12.Interval = 33;
            timer12.Enabled = false;
            timer13.Interval =100;
            timer13.Enabled = false;
            listString2.Add("01");
            listString2.Add("02");
            listString2.Add("03");
            listString2.Add("04");
            listString2.Add("05");
            listString2.Add("06");
            listString2.Add("07");
            listString2.Add("08");
            listString2.Add("09");
            listString2.Add("10");
            listString2.Add("11");
            listString2.Add("12");
            listString2.Add("13");
            listString2.Add("14");
            listString2.Add("15");
            listString2.Add("16");
            listString2.Add("17");
            listString2.Add("18");
            listString2.Add("19");
            listString2.Add("20");
            listString2.Add("21");
            listString2.Add("22");
            listString2.Add("23");
            listString2.Add("24");

        }

        public void dButton_Click(object sender, EventArgs e)
        {
            
                 
            listString3.Clear();
            Button myButton = (Button)sender;

            if (listString.Count < 12)
            {
                    if ((myButton.BackColor == Color.DarkGray)|| (myButton.BackColor == Color.Red))
                    {                             
                        myButton.BackColor = Color.Yellow;
                        listString.Add(myButton.Text);
                    }                 
                    else
                    {
                        myButton.BackColor = Color.DarkGray;
                        listString.Remove(myButton.Text);
                    }
            }
            else
            {
                    if (myButton.BackColor == Color.Yellow)
                    {
                        myButton.BackColor = Color.DarkGray;
                        listString.Remove(myButton.Text);
                    }
                    else
                    {
                        MessageBox.Show("最多只能選擇12個號碼");
                    }

            }
           
            listString.Sort();

            string str訊息 = "";
            foreach(string a in listString)
            {
                str訊息 += a.ToString() + "  ";
            }
            lb選號.Text = str訊息;
           


        }


        public void 動態產生按鈕(int intcount1, int intcount2)
        {
            for (int i = 0; i < intcount1; i += 1)
            {
                for (int j = 0; j < intcount2; j += 1)
                {
                    Button dButton = new Button();
                    dButton.BackColor = Color.DarkGray;
                    dButton.ForeColor = Color.Black;
                    if ((4 * i + j + 1)<10)
                    {
                        dButton.Text = "0" + (4 * i + j + 1).ToString();
                    }
                    else
                    {
                        dButton.Text = (4 * i + j + 1).ToString();
                    }
                    dButton.Name = "btn" + (4 * i + j + 1).ToString();
                    dButton.Font = new Font("微軟正黑體", 16);
                    dButton.Size = new Size(60, 40);
                    dButton.Location = new Point(60 + 62 * j, 100 + 42 * i);
                    dButton.Click += new EventHandler(dButton_Click);
                    //dButton.Click -= new EventHandler(dButton_Click);  解除按鈕事件

                    //Form 裡Controls為List,List為傳址呼叫,不會有複本出現
                    Controls.Add(dButton);//在Form裡案條件設定產生按鈕
                    myDButtonList.Add(dButton);//按鈕的功能(觸發事件的功能)
                }
            }
        }

        private void btn隨機選號_Click(object sender, EventArgs e)
        {
            listString.Clear();
            listString3.Clear();
            Random myRnd = new Random();
            for (int i = 0; i < 12; i += 1)
            {   
                    arrayRndNum[i] = myRnd.Next(1, 25);
                    
                while (Array.IndexOf(arrayRndNum, arrayRndNum[i], 0, i) > -1)
                {                                        
                        arrayRndNum[i] = myRnd.Next(1, 25);                    
                }
            }

            Array.Sort(arrayRndNum);

            for(int r=0;r<24;r+=1)
            {
                myDButtonList[r].BackColor = Color.DarkGray;
            }

          
            

            string str電腦選號 = "";
             
            foreach (int a in arrayRndNum)
            {
                  if (a < 10)
                  {
                    str電腦選號 += "0" + a.ToString() + "  ";
                    listString3.Add("0" + a.ToString());
                    for (int k=0; k<24;k+=1)
                    {
                       
                        if ("0" + a.ToString() == myDButtonList[k].Text)
                        {
                            myDButtonList[k].BackColor = Color.Red;
                        }                     
                    }
                  }
                  else
                  {
                    str電腦選號 += a.ToString() + "  ";
                    listString3.Add(a.ToString());
                    for (int k = 0; k < 24; k += 1)
                    {
                        
                        if (a.ToString() == myDButtonList[k].Text)
                        {
                            myDButtonList[k].BackColor = Color.Red;
                        }

                    }                    
                  }
            }
            lb選號.Text = str電腦選號;

        }
      
        private void btn開獎_Click(object sender, EventArgs e)
        {
            for(int k =0;k<listString4.Count;k+=1)
            {
                listString2.Add(listString4[k]);
            }



            listString4.Clear();
            lb開獎號碼.Text = "";
            lb1.Text = "?";
            lb2.Text = "?";
            lb3.Text = "?";
            lb4.Text = "?";
            lb5.Text = "?";
            lb6.Text = "?";
            lb7.Text = "?";
            lb8.Text = "?";
            lb9.Text = "?";
            lb10.Text = "?";
            lb11.Text = "?";
            lb12.Text = "?";
            timer1.Start();
            btn開獎.Enabled = false;
            btn中獎結果.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            time1 += 1;
            Random myRnd = new Random();
            int a =myRnd.Next(0,24);
            lb1.Text = a.ToString();
            while(time1==30)
            {
                timer1.Stop();
                time1 = 0;
                timer2.Start();
                lb1.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb1.Text);

            }
          

            listString4.Sort();
            string str訊息 = "";
            foreach(string b in listString4)
            {
                str訊息 += b+"  ";
            }
            lb開獎號碼.Text = str訊息;
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            time2 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 23);
            lb2.Text = a.ToString();
            while (time2 == 30)
            {
                timer2.Stop();
                time2 = 0;
                timer3.Start();
                lb2.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb2.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            time3 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 22);
            lb3.Text = a.ToString();
            while (time3 == 30)
            {
                timer3.Stop();
                time3 = 0;
                timer4.Start();
                lb3.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb3.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            time4 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 21);
            lb4.Text = a.ToString();
            while (time4 == 30)
            {
                timer4.Stop();
                time4 = 0;
                timer5.Start();
                lb4.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb4.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            
            time5 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 20);
            lb5.Text = a.ToString();
            while (time5 == 30)
            {
                timer5.Stop();
                time5 = 0;
                timer6.Start();
                lb5.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb5.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            time6 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 19);
            lb6.Text = a.ToString();
            while (time6 == 30)
            {
                timer6.Stop();
                time6 = 0;
                timer7.Start();
                lb6.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb6.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            time7 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 18);
            lb7.Text = a.ToString();
            while (time7 == 30)
            {
                timer7.Stop();
                time7 = 0;
                timer8.Start();
                lb7.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb7.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            time8 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 17);
            lb8.Text = a.ToString();
            while (time8 == 30)
            {
                timer8.Stop();
                time8 = 0;
                timer9.Start();
                lb8.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb8.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            time9 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 16);
            lb9.Text = a.ToString();
            while (time9 == 30)
            {
                timer9.Stop();
                time9 = 0;
                timer10.Start();
                lb9.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb9.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            time10 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 15);
            lb10.Text = a.ToString();
            while (time10 == 30)
            {
                timer10.Stop();
                time10 = 0;
                timer11.Start();
                lb10.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb10.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            time11 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0, 14);
            lb11.Text = a.ToString();
            while (time11 == 30)
            {
                timer11.Stop();
                time11 = 0;
                timer12.Start();
                lb11.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb11.Text);

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
           
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            time12 += 1;
            Random myRnd = new Random();
            int a = myRnd.Next(0,13);
            lb12.Text = a.ToString();
            while (time12 == 30)
            {
                timer12.Stop();
                time12 = 0;
                
                lb12.Text = listString2[a];
                listString2.Remove(listString2[a]);
                listString4.Add(lb12.Text);
                btn開獎.Enabled = true;
                btn中獎結果.Enabled = true;

            }
            listString4.Sort();
            string str訊息 = "";
            foreach (string b in listString4)
            {
                str訊息 += b + "  ";
            }
            lb開獎號碼.Text = str訊息;
        }

        private void btn中獎結果_Click(object sender, EventArgs e)
        {
            timer13.Start();
            Lb目前位置.X = 0;
            if (listString4.Count != 0)
            {
                if (listString.Count > 0)
                {
                    if (listString.Count < 12)
                    {
                        MessageBox.Show("請選滿12個號碼");
                    }
                    else
                    {
                      
                        for (int i = 0; i < 12; i += 1)
                        {
                            for (int j = 0; j < 12; j += 1)
                            {
                                if (listString[i] == listString4[j])
                                {
                                    listString5.Add(listString[i]);
                                }

                            }
                        }
                        string str自選中獎數字 = "";
                        foreach(string p in listString5)
                        {                            
                            str自選中獎數字 += p+" ";
                        }
                        if ((listString5.Count == 12) || (listString5.Count == 0))
                        {
                            lb跑馬燈.Text = "您的中獎號碼:" + str自選中獎數字 + "恭喜您中了頭獎,獲得獎金新台幣1500萬元";
                            MessageBox.Show("恭喜您中了頭獎,獲得獎金新台幣1500萬元");
                        }
                        else if ((listString5.Count == 11) || (listString5.Count == 1))
                        {
                            lb跑馬燈.Text = "您的中獎號碼:\n" + str自選中獎數字 + "恭喜您中了貳獎,獲得獎金新台幣10萬元";
                            MessageBox.Show("恭喜您中了貳獎,獲得獎金新台幣10萬元");
                        }
                        else if ((listString5.Count == 10) || (listString5.Count == 2))
                        {
                            lb跑馬燈.Text = "您的中獎號碼:" + str自選中獎數字 + "恭喜您中了參獎,獲得獎金新台幣500元";
                            MessageBox.Show("恭喜您中了參獎,獲得獎金新台幣500元");
                        }
                        else if ((listString5.Count == 9) || (listString5.Count == 3))
                        {
                            lb跑馬燈.Text = "您的中獎號碼:" + str自選中獎數字 + "恭喜您中了肆獎,獲得獎金新台幣100元";
                            MessageBox.Show("恭喜您中了肆獎,獲得獎金新台幣100元");
                        }
                        else
                        {
                            lb跑馬燈.Text = "您的中獎號碼:" + str自選中獎數字 + "很抱歉您沒中獎,請下次再來";
                            MessageBox.Show("很抱歉您沒中獎,請下次再來");
                        }

                    }
                   

                }
                else if(listString3.Count !=0)
                {
                    for (int i = 0; i < 12; i += 1)
                    {
                        for (int j = 0; j < 12; j += 1)
                        {
                            if (listString3[i] == listString4[j])
                            {
                                listString6.Add(listString3[i]);
                            }

                        }
                    }
                    string str隨機中獎數字 = "";
                    foreach (string q in listString6)
                    {
                        str隨機中獎數字 += q+" ";
                    }
                    if ((listString6.Count == 12) || (listString6.Count == 0))
                    {
                        lb跑馬燈.Text = "您的中獎號碼:" + str隨機中獎數字+ "\n恭喜您中了頭獎,獲得獎金新台幣1500萬元";
                        MessageBox.Show("恭喜您中了頭獎,獲得獎金新台幣1500萬元");
                    }
                    else if ((listString6.Count == 11) || (listString6.Count == 1))
                    {
                        lb跑馬燈.Text = "您的中獎號碼:" + str隨機中獎數字+ "\n恭喜您中了貳獎,獲得獎金新台幣10萬元";
                        MessageBox.Show("恭喜您中了貳獎,獲得獎金新台幣10萬元");
                    }
                    else if ((listString6.Count == 10) || (listString6.Count == 2))
                    {
                        lb跑馬燈.Text = "您的中獎號碼:" + str隨機中獎數字+"\n恭喜您中了參獎,獲得獎金新台幣500元";
                        MessageBox.Show("恭喜您中了參獎,獲得獎金新台幣500元");
                    }
                    else if ((listString6.Count == 9) || (listString6.Count == 3))
                    {
                        lb跑馬燈.Text = "您的中獎號碼:" + str隨機中獎數字+ "\n恭喜您中了肆獎,獲得獎金新台幣100元";
                        MessageBox.Show("恭喜您中了肆獎,獲得獎金新台幣100元");
                    }
                    else
                    {
                        lb跑馬燈.Text = "您的中獎號碼:" + str隨機中獎數字+ "\n很抱歉您沒中獎,請下次再來";
                        MessageBox.Show("很抱歉您沒中獎,請下次再來");
                    }
                }
                else
                {
                    MessageBox.Show("請手動選號或隨機選號");
                }
            }
            else
            {
                MessageBox.Show("請開出本期號碼");
            }
           
           
            
            listString5.Clear();
            listString6.Clear();


          
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            Lb目前位置.X += 4;
            lb跑馬燈.Location = Lb目前位置;
            while (Lb目前位置.X == 840)
            {
                Lb目前位置.X = 0;                               
            }
               
            


        }
    }
}

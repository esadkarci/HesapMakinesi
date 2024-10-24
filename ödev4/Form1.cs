namespace ödev4
{
    public partial class Form1 : Form
    {
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();
        Button btn5 = new Button();
        Button btn6 = new Button();
        Button btn7 = new Button();
        Button btn8 = new Button();
        Button btn9 = new Button();
        Label lbl1 = new Label();
        Label lbl2 = new Label();
        Label lbl3 = new Label();
        Label lbl4 = new Label();
        Label lbl5 = new Label();
        Label lbl6 = new Label();
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btn1.Text = "+";
            btn1.Size=new Size(30,30);
            btn1.Location = new Point(50,200);
            this.Controls.Add(btn1);
            btn1.Click += Btn1_Click;

            
            btn2.Text = "-";
            btn2.Size = new Size(30, 30);
            btn2.Location = new Point(90, 200);
            this.Controls.Add(btn2);
            btn2.Click += Btn2_Click;

            
            btn3.Text = "x";
            btn3.Size = new Size(30, 30);
            btn3.Location = new Point(130, 200);
            this.Controls.Add(btn3);
            btn3.Click += Btn3_Click;

            
            btn4.Text = "/";
            btn4.Size = new Size(30, 30);
            btn4.Location = new Point(170, 200);
            this.Controls.Add(btn4);
            btn4.Click += Btn4_Click;

            
            btn5.Text = "Logritma a^b";
            btn5.Size = new Size(100, 30);
            btn5.Location = new Point(210, 200);
            this.Controls.Add(btn5);
            btn5.Click += Btn5_Click;

            
            btn6.Text = "ÖZET";
            btn6.Size = new Size(70, 30);
            btn6.Location = new Point(320, 200);
            this.Controls.Add(btn6);
            btn6.Click += Btn6_Click;

            
            btn7.Text = "Asal Mı";
            btn7.Size = new Size(100, 30);
            btn7.Location = new Point(400, 200);
            this.Controls.Add(btn7);
            btn7.Click += Btn7_Click;

            
            btn8.Text = "Faktöriyel";
            btn8.Size = new Size(100, 30);
            btn8.Location = new Point(640, 200);
            this.Controls.Add(btn8);
            btn8.Click += Btn8_Click;

            
            btn9.Text = "sayı1^sayı2";
            btn9.Size = new Size(120, 30);
            btn9.Location = new Point(510, 200);
            this.Controls.Add(btn9);
            btn9.Click += Btn9_Click;

            
            lbl1.Text = "Sayı1(logaritmik işlemde taban değeri ve Bulunacak asal sayı buraya yazılır):";
            lbl1.Size = new Size(250, 30);
            lbl1.Location = new Point(50, 100);
            this.Controls.Add(lbl1);

            
            lbl2.Text = "Sayı2(logaritmik işlemde üst değeri ve faktoriyel bulunacak değer yazılır.):";
            lbl2.Size = new Size(250, 30);
            lbl2.Location = new Point(50, 150);
            this.Controls.Add(lbl2);

            
            lbl3.Text = "Ozet:";
            lbl3.Size = new Size(40, 30);
            lbl3.Location = new Point(50, 320);
            this.Controls.Add(lbl3);

            
            lbl4.Size = new Size(1000, 50);
            lbl4.Location = new Point(100, 320);
            this.Controls.Add(lbl4);

            
            lbl5.Text = "Sonuc:";
            lbl5.Size = new Size(45, 30);
            lbl5.Location = new Point(50, 250);
            this.Controls.Add(lbl5);

            
            lbl6.Size = new Size(1000, 30);
            lbl6.Location = new Point(100, 250);
            this.Controls.Add(lbl6);

            
            txt1.Size = new Size(100, 30);
            txt1.Location = new Point(300, 100);
            this.Controls.Add(txt1);

            
            txt2.Size = new Size(100, 30);
            txt2.Location = new Point(300, 150);
            this.Controls.Add(txt2);

        }

        private void Btn9_Click(object? sender, EventArgs e)
        {
            lbl6.Text = Math.Pow(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text)).ToString();

        }

        private void Btn8_Click(object? sender, EventArgs e)
        {
            double faktoriyel = 1;
            for (int i = 1; i <= Convert.ToDouble(txt2.Text); i++)
                faktoriyel *= i;

            lbl6.Text = faktoriyel.ToString();
        }

        private void Btn7_Click(object? sender, EventArgs e)
        {
            int sayac = 0;
            
            int sayi = Convert.ToInt32(txt1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 2)
            {
                lbl6.Text="Girdiğiniz sayı Asal Sayıdır.";
            }
            else
            {
                lbl6.Text="Girdiğiniz sayı Asal Sayı Değildir.";
            }
        }

        private void Btn6_Click(object? sender, EventArgs e)
        {
            lbl4.Text = "1. sayı="+txt1.Text+"\n"+"2.sayı="+txt2.Text+"\n"+"Sonuç="+lbl6.Text;
        }

        private void Btn5_Click(object? sender, EventArgs e)
        {
            lbl6.Text = Math.Log(Convert.ToDouble(txt2.Text), Convert.ToDouble(txt1.Text)).ToString();
        }

        private void Btn4_Click(object? sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt1.Text);
            double sayi2 = Convert.ToDouble(txt2.Text);
            this.lbl6.Text = (sayi1 / sayi2).ToString();
        }

        private void Btn3_Click(object? sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt1.Text);
            double sayi2 = Convert.ToDouble(txt2.Text);
            this.lbl6.Text = sayi1+"x"+sayi2+"="+(sayi1 * sayi2).ToString();
        }

        private void Btn2_Click(object? sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt1.Text);
            double sayi2 = Convert.ToDouble(txt2.Text);
            this.lbl6.Text = (sayi1 - sayi2).ToString();
        }

        private void Btn1_Click(object? sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt1.Text);
            double sayi2 = Convert.ToDouble(txt2.Text);
            this.lbl6.Text = (sayi1 + sayi2).ToString();


        }
    }
}

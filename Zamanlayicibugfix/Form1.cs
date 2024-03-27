namespace Zamanlayicibugfix
{
    public partial class Form1 : Form
    {
        
        int saniye = 59; //sag taraftaki saniyeyi yonetmek icin
        int dakika;     //sol taraftaki dakikayi yonetmek icin
        int enbas = 00; //sol alttaki zamanlayicinin ne kadar gectigini gormek icin 
        bool calisio = false;  //ileri giden sayacý durdurup baþlatabilmek için
        bool geridonus = false; //geriye giden sayacý durdurup baslatabilmek için
        int maximumbar;
        bool bartimer = false; //progressbarýn durup baþlatýlabilmesi için

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.Hour.ToString();
            label7.Text = DateTime.Now.Minute.ToString(); // sað alttaki güncel saatler için
            label8.Text = DateTime.Now.Second.ToString();


            if (bartimer == true) // eger bartimer deðiþkeni true olursa timer döngüsü çalýþmaya baþlasýn diye
            {
                progressBar1.Increment(1); // progressbarýn ilerlemesi için


            }
            if (progressBar1.Value == progressBar1.Maximum && bartimer == true) // en sonda baþarýlý mesajý çýkar ve diger timerlarýn hepsi durur
            {
                bartimer = false;
                geridonus = false;
                calisio = false;
                label3.Text = "00";
                label9.Text = "00";

                MessageBox.Show("Zamanlayici tamamlandi");
                

            }

            if (calisio == true) // sol alttaki sayacýn artmasýný saglar
            {
                enbas++;
                label4.Text = Convert.ToString(enbas);
            }
            if (geridonus == true) //gercek sayacýn azalmasýný saglar
            {
                label9.Text = Convert.ToString(saniye);
                saniye--;
                if (saniye == -1) // -1 verdim ki 00 ý görebileyim diye
                {
                    dakika--;
                    label3.Text = Convert.ToString(dakika - 1); //burda da -1 þeklinde yazdýrmak gerekiyo çünkü saniye 00 a ulaþmýþ olucak

                    saniye = 59;
                }
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            maximumbar=Convert.ToInt32(textBox1.Text);   //maximumbar degiskenini yazýlan sayýya esitledim
            progressBar1.Maximum = maximumbar*60;     // donguyle ayný anda bitsin diye 60 çarptým
            

            dakika = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(dakika - 1);
            label3.Text = textBox1.Text;

            saniye = 59;
            enbas = 0;
            timer1.Start();
            calisio = true;
            geridonus = true;
            bartimer = true;



            if (textBox1.Text == "")
            {
                MessageBox.Show("Bu kutucuk bos birakilamaz"); // Kutucuðu boþ býraktýðýnýzda uygulamayý kapatan bir þart koydum
                Close();
            }
            textBox1.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            calisio = false;
            geridonus = false;    //Durdurma
            bartimer = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 2;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Burda textboxa sadece integer deðerler girilsin diye kod yazdým burayý internetten araþtýrdým
            {
                e.Handled = true;               
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            calisio = true;
            geridonus = true; //Döngüleri calýstýrmaya devam ettiren tuþ
            bartimer = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

      

       
    }
}

namespace Zamanlayicibugfix
{
    public partial class Form1 : Form
    {
        
        int saniye = 59; //sag taraftaki saniyeyi yonetmek icin
        int dakika;     //sol taraftaki dakikayi yonetmek icin
        int enbas = 00; //sol alttaki zamanlayicinin ne kadar gectigini gormek icin 
        bool calisio = false;  //ileri giden sayac� durdurup ba�latabilmek i�in
        bool geridonus = false; //geriye giden sayac� durdurup baslatabilmek i�in
        int maximumbar;
        bool bartimer = false; //progressbar�n durup ba�lat�labilmesi i�in

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
            label7.Text = DateTime.Now.Minute.ToString(); // sa� alttaki g�ncel saatler i�in
            label8.Text = DateTime.Now.Second.ToString();


            if (bartimer == true) // eger bartimer de�i�keni true olursa timer d�ng�s� �al��maya ba�las�n diye
            {
                progressBar1.Increment(1); // progressbar�n ilerlemesi i�in


            }
            if (progressBar1.Value == progressBar1.Maximum && bartimer == true) // en sonda ba�ar�l� mesaj� ��kar ve diger timerlar�n hepsi durur
            {
                bartimer = false;
                geridonus = false;
                calisio = false;
                label3.Text = "00";
                label9.Text = "00";

                MessageBox.Show("Zamanlayici tamamlandi");
                

            }

            if (calisio == true) // sol alttaki sayac�n artmas�n� saglar
            {
                enbas++;
                label4.Text = Convert.ToString(enbas);
            }
            if (geridonus == true) //gercek sayac�n azalmas�n� saglar
            {
                label9.Text = Convert.ToString(saniye);
                saniye--;
                if (saniye == -1) // -1 verdim ki 00 � g�rebileyim diye
                {
                    dakika--;
                    label3.Text = Convert.ToString(dakika - 1); //burda da -1 �eklinde yazd�rmak gerekiyo ��nk� saniye 00 a ula�m�� olucak

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
            maximumbar=Convert.ToInt32(textBox1.Text);   //maximumbar degiskenini yaz�lan say�ya esitledim
            progressBar1.Maximum = maximumbar*60;     // donguyle ayn� anda bitsin diye 60 �arpt�m
            

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
                MessageBox.Show("Bu kutucuk bos birakilamaz"); // Kutucu�u bo� b�rakt���n�zda uygulamay� kapatan bir �art koydum
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Burda textboxa sadece integer de�erler girilsin diye kod yazd�m buray� internetten ara�t�rd�m
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
            geridonus = true; //D�ng�leri cal�st�rmaya devam ettiren tu�
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

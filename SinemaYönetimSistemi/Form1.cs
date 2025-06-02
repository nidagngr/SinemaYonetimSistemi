namespace SinemaYönetimSistemi
{
    public partial class Form1 : Form
    {
        List<Salon> salonlist = new List<Salon>();

        List<object> filmlist = new List<object>();
        int bosKoltuk = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //Salon salon1 = new Salon();
        //Salon salon2 = new Salon();

        private void button1_Click(object sender, EventArgs e)
        {
            salonEkle();


        }

        public bool salonEkle()
        {
            Salon salonlar = new Salon(1, textBox1.Text, int.Parse(textBox2.Text));
            /*salon1.SalonId = 1;
            salon1.FilmName = "aaaa";
            salon1.bosKoltukSayi = 5;

            //filmlist.Add(salon1);


            salonlist.Add(salon1);
            salonlist.Add(salon2);
            */
            salonlist.Add(salonlar);
            filmlist.Add(salonlar.FilmName);

            // listBox1.Items.Add(salon1.SalonId + " " + salon1.FilmName + " " + salon1.bosKoltukSayi);
            listBox1.Items.Add(salonlar.SalonId + " " + salonlar.FilmName + " " + salonlar.doluKoltukSayi);

            return true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filmlist.Count(); i++)
            {
                if (!comboBox1.Items.Contains(filmlist[i]))//combobox ta tekrar tekrar eklemesin diye 
                {
                    comboBox1.Items.Add(filmlist[i]);
                }
                //comboBox1.Items.Clear();
            }
        }
        public int calculate(int koltuk, int doluKoltuk)
        {
            int bosSeat = koltuk - doluKoltuk;
            return bosSeat;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            for (int j = 0; j < filmlist.Count(); j++)
            {


                if (comboBox1.SelectedIndex == j)
                {

                    if (comboBox1.Text.Equals(salonlist[j].FilmName))
                    {

                        bosKoltuk = calculate(salonlist[j].KoltukSayi, salonlist[j].doluKoltukSayi);
                        comboBox2.Items.Clear();//bütün filmlere ait boş koltukları göstermesin diye 
                        comboBox2.Items.Add(bosKoltuk);
                    }


                }

            }

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            
            Salon satisSalon = new Salon();
            for (int i = 0; i < filmlist.Count; i++)
            {
                if (comboBox1.SelectedIndex == i)
                {

                    if (comboBox1.Text.Equals(salonlist[i].FilmName))
                    {
                        satisSalon = salonlist[i];

                        satisSalon.doluKoltukSayi++;
                        
                    }


                }

            }
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex= -1;
        }
    }
}

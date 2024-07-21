namespace projekat_tvp
{
    public partial class Form1 : Form
    {

        private Korisnik trenutnoPrijavljeniKorisnik;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetodeZaCitanje.UcitajKorisnike();
        }

        private void btnprijava_Click(object sender, EventArgs e)
        {
            if(txtImelogin.Text.Length == 0 || txtLozinkalogin.Text.Length == 0) 
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }

            bool pronadjen = false;

            foreach(Korisnik k in BazaKorisnika.Korisnici)
            {
                if(k.korisnicko_ime == txtImelogin.Text && k.korisnicka_lozinka == txtLozinkalogin.Text)
                {
                    pronadjen = true;
                    trenutnoPrijavljeniKorisnik = k;
                    break;
                }
            }

            if(pronadjen)
            {
                MessageBox.Show("Uspesna prijava!");
                
                if(trenutnoPrijavljeniKorisnik.tip == Korisnik.TipKorisnika.Klijent)
                {
                    FormaKlijent frmklijent = new FormaKlijent(trenutnoPrijavljeniKorisnik);
                    frmklijent.Show();
                }
                else if(trenutnoPrijavljeniKorisnik.tip == Korisnik.TipKorisnika.Admin)
                {
                    FormaAdministracija formaAdministracija = new FormaAdministracija();
                    formaAdministracija.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogresno korisnicko ime ili lozinka!");
            }

        }


        private void btninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROBNI AKAUNTI:\n\n\nKorisnik: proba1 , proba123\nAdmin: proba1_A , proba123_A");
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FormaRegistracija formaRegistracija = new FormaRegistracija();
            formaRegistracija.Show();
        }
    }
}

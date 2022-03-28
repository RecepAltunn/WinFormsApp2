namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kullanıcılar = new Dictionary<string,string>();
            kullanıcılar.Add("Recep","123");
            kullanıcılar.Add("Emre","1234");
            kullanıcılar.Add("Kaan","12345");
        }
        int hak = 3;
        Dictionary<string,string> kullanıcılar;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisyap_Click(object sender, EventArgs e)
        {
            var list = (from a in kullanıcılar
                        where a.Key.ToLower() == txtKullanıcıadı.Text.ToLower() && a.Value == txtSifre.Text
                        select a).ToList();
            if (list.Count>0)
            {
                MessageBox.Show("Hoş Geldin Admin");
                Form2 frm=new Form2();
                frm.Show();
               this.Hide();
            }
            else
                MessageBox.Show($"Hatalı bilgi.Kalan hakkınız {--hak}  ");
            
            if(hak == 0)
                btnGirisyap.Enabled = false;
        }
    }
}
using MyDataService.Models;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async Task Index()
        {
            List<Gubudik> Listem = new List<Gubudik>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5223/store"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Listem = JsonConvert.DeserializeObject<List<Gubudik>>(apiResponse);
                }
            }

            this.dataGridView1.DataSource=Listem;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Index();
        }
    }
}
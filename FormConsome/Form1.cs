using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace FormConsome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {


            buscartodos();




        }



        private async void buscartodos()
        {
            // using httpclient para fechar ao terminar de executar
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44319/api/usuarios");
                var resposta = await client.GetAsync("");
                var dados = await resposta.Content.ReadAsStringAsync();

                var JsonConvert = new JavaScriptSerializer();

                List<usuarios> u = JsonConvert.Deserialize<List<usuarios>>(dados);



                GridView1.DataSource = u;





            }



        }


        //private async void buscarporid(string cod)
        //{
        //   // using httpclient para fechar ao terminar de executar
        //    using (var client = new HttpClient())
        //    {

        //        client.BaseAddress = new Uri("https://localhost:44319/api/usuarios/" + cod);
        //        var resposta = await client.GetAsync("https://localhost:44319/api/usuarios/" + cod);

        //        if (resposta.IsSuccessStatusCode)
        //        {
        //            string dados = await resposta.Content.ReadAsStringAsync();



        //            var JsonConvert = new JavaScriptSerializer();

        //            List<usuarios> u = JsonConvert.Deserialize<List<usuarios>>(dados);


        //            GridView1.DataSource = u;
        //        }
        //        else
        //        {
        //            MessageBox.Show("ERRO AO BUSCAR !!!!!!!!!!");
        //        }






        //    }





        //}


        private async Task buscarporid(string cod)
        {
            using(var client = new HttpClient())
            {

                BindingSource bsdados = new BindingSource();
                client.BaseAddress = new Uri("https://localhost:44319/api/usuarios/"+cod);
                var resposta = await client.GetAsync("");
                

                if(resposta.IsSuccessStatusCode)
                {
                    var dados = await resposta.Content.ReadAsStringAsync();

                    bsdados.DataSource = JsonConvert.DeserializeObject<usuarios>(dados);

                    this.GridView1.DataSource = bsdados;

                }


            }



        }







        private async void button2_Click(object sender, EventArgs e)
        {
            await buscarporid(textBox1.Text);
        }
    }




    public class usuarios
    {
        public int cod_cliente { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }
        public string telresidencial { get; set; }
        public string telcelular { get; set; }
        public string rg { get; set; }
        public string email { get; set; }
        public object cidade { get; set; }
        public int cod_cidade { get; set; }
    }

    


}
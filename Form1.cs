using System.Data;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace APIs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int idPokemon = 1;
        private Point mouseLoc;
        JObject data;
        private void pokedex_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = e.Location;
        }

        private void pokedex_mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouseLoc.X;
                int dy = e.Location.Y - mouseLoc.Y;
                dx += this.Location.X;
                dy += this.Location.Y;
                this.Location = new Point(dx, dy);

            }
        }

        private void cargaImagen()
        {
            string file = idPokemon.ToString("000");
            idLabel.Text = file;
            string pfile = $"images\\{file}.png";
            pokemon.Image = Image.FromFile(pfile);
            string id = idPokemon.ToString();
            string nombre = data?["pokemon"]?[id]?["N"]?.Value<string>() ?? "";
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre);
        }

        private void Form1_load(object sender, EventArgs e)
        {
            name.Parent = pokedex;
            name.BackColor = System.Drawing.Color.Transparent;

            string text = File.ReadAllText("pokemon.json");
            data = JObject.Parse(text);
            cargaImagen();
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (idPokemon >= 777)
                idPokemon = 1;
            else
                idPokemon++;
            cargaImagen();
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (idPokemon <= 1)
                idPokemon = 777;
            else
                idPokemon--;
            cargaImagen();
        }
    }
}
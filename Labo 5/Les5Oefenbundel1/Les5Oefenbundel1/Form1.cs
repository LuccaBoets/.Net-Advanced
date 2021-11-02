using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les5Oefenbundel1
{
    public partial class Form1 : Form
    {

        public List<Player> players { get; set; }

        public Form1()
        {
            InitializeComponent();

            players = Program.GetPlayers();


        }

        private void knop(object sender, EventArgs e)
        {
            var playerFines = players.Select(x => new PlayerFine() { PlayerId = x.Id, PlayerInitials = x.Initials, PlayerName = x.LastName, PlayerStreet = x.Street, PlayerLocation = x.City, PlayerHouseNumber = x.Number, PlayerZipcode = x.ZipCode, NumberOfFines = x.Fines.Count }).ToList();
            dataGridView1.DataSource = playerFines;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            // init player
            _player = new Player
            {
                MaxHitPoints = 10,
                CurrentHitPoints = 10,
                Gold = 20,
                ExperiencePoints = 0,
                Level = 1
            };

            // set labels to player stats
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blutbad
{
    public partial class Blutbad : Form
    {
        
        

        public Blutbad()
        {
            InitializeComponent();
            UpdateButtons(Engine.World.player.CurrentLocation);

        }

        

        private void btnNorth_Click(object sender, EventArgs e)
        {
            if(Engine.World.player.CurrentLocation.LocationToNorth == null)
            {
                return;
            }
            Engine.World.player.CurrentLocation = Engine.World.player.CurrentLocation.LocationToNorth;
            UpdateButtons(Engine.World.player.CurrentLocation);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            if (Engine.World.player.CurrentLocation.LocationToWest == null)
            {
                return;
            }
            Engine.World.player.CurrentLocation = Engine.World.player.CurrentLocation.LocationToWest;
            UpdateButtons(Engine.World.player.CurrentLocation);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            if (Engine.World.player.CurrentLocation.LocationToEast == null)
            {
                return;
            }
            Engine.World.player.CurrentLocation = Engine.World.player.CurrentLocation.LocationToEast;
            UpdateButtons(Engine.World.player.CurrentLocation);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            if (Engine.World.player.CurrentLocation.LocationToSouth == null)
            {
                return;
            }
            Engine.World.player.CurrentLocation = Engine.World.player.CurrentLocation.LocationToSouth;
            UpdateButtons(Engine.World.player.CurrentLocation);
        }

        private void UpdateButtons(Engine.Locations currentLocation)
        {
            if (currentLocation.LocationToNorth == null)
            {
                btnNorth.Visible = false;
            }
            else
            {
                btnNorth.Visible = true;
            }
            if (currentLocation.LocationToSouth == null)
            {
                btnSouth.Visible = false;
            }
            else
            {
                btnSouth.Visible = true;
            }
            if (currentLocation.LocationToWest == null)
            {
                btnWest.Visible = false;
            }
            else
            {
                btnWest.Visible = true;
            }
            if (currentLocation.LocationToEast == null)
            {
                btnEast.Visible = false;
            }
            else
            {
                btnEast.Visible = true;
            }
        }

        
    }
}

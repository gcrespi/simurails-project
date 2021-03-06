﻿using SimuRails.Models;
using SimuRails.Views.Components;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public partial class Simulacion : Form
    {
        public Simulacion()
        {
            InitializeComponent();
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            List<Traza> trazas = new List<Traza>();
            var traza1 = new Traza();
            traza1.Nombre = "San Martín Completo";
            trazas.Add(traza1);
            var traza2 = new Traza();
            traza2.Nombre = "Mitre (Retiro - Tigre)";
            trazas.Add(traza2);
            var traza3 = new Traza();
            traza3.Nombre = "Belgrano Sur";
            trazas.Add(traza3);

            for (int i = 0; i < trazas.Count; i++)
            {
                var renglon = this.renglonDe(trazas.ElementAt(i), i);
                
            }

                
        }

        private RenglonDeTraza renglonDe(Traza traza, Int32 indice)
        {
            var renglon = new RenglonDeTraza(traza);
            renglon.Location = new System.Drawing.Point(5, 25 + indice * 48);
            renglon.Width = this.listPanel.Width;
            renglon.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            this.listPanel.Controls.Add(renglon);
            return renglon;
        }
    }
}

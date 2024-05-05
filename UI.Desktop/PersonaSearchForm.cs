﻿using Business.Entities;
using Business.Entities.Enums;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class PersonaSearchForm : Form
    {
        private PersonaLogic PersonaLogic => new PersonaLogic();

        private TipoPersonaEnum TipoPersona { get; set; }

        public Persona Persona { get; set; }

        public PersonaSearchForm()
        {
            InitializeComponent();
            this.dgvPersonas.AutoGenerateColumns = false;
        }

        private void PersonaSearchForm_Load(object sender, EventArgs e)
        {
            this.cbTipoPersona.DataSource = Enum.GetValues(typeof(TipoPersonaEnum));
            this.dgvPersonas.DataSource = this.PersonaLogic.GetPersonas((TipoPersonaEnum)this.cbTipoPersona.SelectedValue);
        }

        private void cbTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvPersonas.DataSource = this.PersonaLogic.GetPersonas((TipoPersonaEnum)this.cbTipoPersona.SelectedValue);
        }
    }
}

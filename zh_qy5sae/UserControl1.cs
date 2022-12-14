using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh_qy5sae
{
    public partial class UserControl1 : UserControl
    {
        Models.Receptcontext context = new Models.Receptcontext();
        public UserControl1()
        {
            InitializeComponent();
            FillListBox();
            
            
        }

        private void listBoxFogasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ID = ((Models.Fogasok)listBoxFogasok.SelectedItem).FogasId;


            var recept = from x in context.Receptek
                         where x.FogasId == ID
                         select x;
                             

            dataGridView1.DataSource = recept.ToList();
            
            
            

        }

        private void FillListBox()
        {
            var fogasok = from x in context.Fogasok
                          where x.FogasNev.Contains(textBoxKereso.Text)
                          select x;

            listBoxFogasok.DataSource = fogasok.ToList();
            listBoxFogasok.DisplayMember = "FogasNev";
        }

        private void textBoxKereso_TextChanged(object sender, EventArgs e)
        {
            FillListBox();
        }
    }
}

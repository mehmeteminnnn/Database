﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace databasegiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan =new SqlConnection("Data Source=MONSTER;Initial Catalog=ogrencıler;Integrated Security=True");
        private void verilerimigoster()
        {
          baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from bilgiler",baglan );
            SqlDataReader oku=komut.ExecuteReader();
            while(oku.Read())
            {ListViewItem ekle=new ListViewItem();
                ekle.Text = oku["adsoyad"].ToString();
                ekle.SubItems.Add(oku["sehir"].ToString());
                ekle.SubItems.Add(oku["okul"].ToString());
                listView1.Items.Add(ekle);

            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerimigoster();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

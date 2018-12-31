using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace P2
{
    public partial class Form1 : Form
    {
        List<PictureBox> listaPic ;
        public Image novafoto;
        public Form1()
        {
          
         
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaPic = new List<PictureBox>()
            {
                pic1,pic2,pic3,pic4,pic5,pic6,pic7,pic8,pic9
            };
        }
        public void distribuitFoto()
        {
            Bitmap foto;
            Graphics grafico;
            int pos1=0;
            int pos2=0;
            Random aleatorio = new Random();
            int index = 0;
            foreach (PictureBox pic in listaPic)
            {
                index = aleatorio.Next(0,9);
                foto = new Bitmap(100, 100);
                grafico = Graphics.FromImage(foto);
                grafico.DrawImage(novafoto,
                    new Rectangle(0, 0, 100, 100),
                    new Rectangle(pos1, pos2, 100, 100),
                    GraphicsUnit.Pixel);
                listaPic[index].Image = foto;
                pos1 += 100;
                if (pos1 == 300)
                {
                    pos1 = 0;
                    pos2 += 100;
                }
                
            }
 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap  endereco = new Bitmap(openFileDialog1.FileName);
            Bitmap foto = new Bitmap(endereco, pictureBox1.Size);
            pictureBox1.Image = foto;
            novafoto = foto;
            distribuitFoto();
             
        }
        public void Randon()
        {
            
        }

        public void mover(PictureBox p2,PictureBox p1)
        {
            if (p1.Image==pic9.Image)
            {
                p1.BackgroundImage = p2.BackgroundImage;
                p2.BackgroundImage = pic9.BackgroundImage;
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {

        }

        private void pic3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void pic5_Click(object sender, EventArgs e)
        {

        }

        private void pic4_Click(object sender, EventArgs e)
        {

        }

        private void pic9_Click(object sender, EventArgs e)
        {

        }

        private void pic6_Click(object sender, EventArgs e)
        {

        }

        private void pic7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            distribuitFoto();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

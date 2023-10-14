using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProj;

namespace Lab1_Bobrov
{
    public partial class Form1 : Form
    {
        Domino dom1 = new Domino();
        Domino dom2 = new Domino();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dom1.SetEdges();
            label_first.Text = Domino.ReturnEdges(dom1.edge1, dom1.edge2);
            
        }

        private void SetDomino1_Click(object sender, EventArgs e)
        {
            try
            {
               // dom1.edge1 = int.Parse(BoxDomino1.Text); ;
                int edg1 = int.Parse(BoxDomino1.Text);
                int edg2 = int.Parse(BoxDomino2.Text);
                if ((0 < edg1) & (edg1 < 7) & (0 < edg2) & (edg2 < 7))
                {
                    Domino.HandySetDomino(dom1, edg1, edg2);
                    LabelResult.Text = "Успешно!";
                    label_first.Text = Domino.ReturnEdges(dom1.edge1, dom1.edge2);
                }
            }
            catch
            {
                LabelResult.Text = "Ошибка в вводе значений домино";
            }
            
            
        }

        private void SetDomino2_Click(object sender, EventArgs e)
        {
            try
            {
                int edg1 = int.Parse(BoxDomino1.Text);
                int edg2 = int.Parse(BoxDomino2.Text);
                if ((0 < edg1) & (edg1 < 7) & (0 < edg2) & (edg2 < 7))
                {
                    Domino.HandySetDomino(dom2, edg1, edg2);
                    LabelResult.Text = "Успешно!";
                    label_second.Text = Domino.ReturnEdges(dom2.edge1, dom2.edge2);
                }
                else
                {
                    LabelResult.Text = "Значения домино должны быть от 1 до 6";
                }
            }
            catch
            {
                LabelResult.Text = "Ошибка в вводе значений домино";
            }
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            LabelTurn.Text = Domino.TestThisTurn(dom1, dom2);

        }
    }
}

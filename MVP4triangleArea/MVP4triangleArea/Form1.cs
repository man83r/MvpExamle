using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP4triangleArea.View;
using MVP4triangleArea.Presenters;


namespace MVP4triangleArea
{
    public partial class Form1 : Form, IView
    {
        public string Side1 { get => tbSide1.Text; set => tbSide1.Text = value; }
        public string Side2 { get => tbSide2.Text; set => tbSide2.Text = value; }
        public string Side3 { get => tbSide3.Text; set => tbSide3.Text = value; }
        public string Area { get => lArea.Text; set => lArea.Text = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presenter presenter = new Presenter(this);
            presenter.getArea();
        }
    }
}

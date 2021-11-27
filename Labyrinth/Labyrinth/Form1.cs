using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //При касании любой стены лабиринта, позиция будет обновляться до стартового.
        private void label71_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60); 
        }
        //Выставляем стартовую позицию курсора.
        // +55 и +60 это позиция labelStart относительно позиции формы на рабочем столе.
        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
        }

        //При наведении на финишный label появится сообщение.
        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Победа!!!","Ура!!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label61_Click(object sender, EventArgs e)
        {

        }
    }
}

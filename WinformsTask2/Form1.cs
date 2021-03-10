using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsTask2.Entities;

namespace WinformsTask2
{
    public partial class Form1 : Form
    {

        // draggable private members
        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;


        // Workers

        public IList<Worker> Workers { get; set; }

        public bool Changes { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void DraggablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void DraggablePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void DraggablePanel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataToDropBox();
        }

        private void LoadBtn_MouseEnter(object sender, EventArgs e)
        {
            this.LoadBtn.BackColor = Color.DodgerBlue;
        }

        private void LoadBtn_MouseLeave(object sender, EventArgs e)
        {
            this.LoadBtn.BackColor = Color.DeepSkyBlue;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (WorkersComboBox.Items.Count == 0)
            {
                MessageBox.Show("Worker list empty. You must add new worker!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(WorkersComboBox.Text))
            {
                MessageBox.Show("You must be select worker!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var worker = GetWorker(WorkersComboBox.SelectedIndex);

            var form2 = new Form2(this, worker);

            this.Hide();

            form2.Show();
        }

        private void CreateBtn_MouseEnter(object sender, EventArgs e)
        {
            this.CreateBtn.BackColor = Color.DodgerBlue;
        }

        private void CreateBtn_MouseLeave(object sender, EventArgs e)
        {
            this.CreateBtn.BackColor = Color.DeepSkyBlue;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form2 = new Form2(this);

            form2.Show();
        }

        private void LoadData()
        {
            FileHelper.FileName = "workers.json";

            if (File.Exists(FileHelper.FileName))
            {
                Workers = FileHelper.ReadFromJson();
            }
            else
            {
                Workers = new List<Worker>();
            }
        }

        private void LoadDataToDropBox()
        {
            WorkersComboBox.Items.Clear();
            
            foreach (var worker in Workers)
            {
                WorkersComboBox.Items.Add(worker.GetFullname());
            }
        }

        private Worker GetWorker(int index)
        {
            return Workers[index];
        }

        public new void Show()
        {
            if (Changes)
            {
                LoadDataToDropBox();
                Changes = false;
            }

            base.Show();
        }
    }
}